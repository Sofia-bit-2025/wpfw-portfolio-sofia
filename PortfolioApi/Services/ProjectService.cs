using Microsoft.EntityFrameworkCore;
using PortfolioApi.Data;
using PortfolioApi.DTOs;
using PortfolioApi.Models;

namespace PortfolioApi.Services;

public sealed class ProjectService : IProjectService
{
    private readonly PortfolioDbContext _dbContext;

    public ProjectService(PortfolioDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<IReadOnlyList<ProjectResponse>> GetAllAsync(CancellationToken cancellationToken)
    {
        var projects = await _dbContext.Projects.AsNoTracking()
            .OrderByDescending(project => project.Datum)
            .ThenBy(project => project.Id)
            .ToListAsync(cancellationToken);

        return projects.Select(ToResponse).ToList();
    }

    public async Task<ProjectResponse?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var project = await _dbContext.Projects.AsNoTracking()
            .FirstOrDefaultAsync(project => project.Id == id, cancellationToken);

        return project is null ? null : ToResponse(project);
    }

     public async Task<ProjectResponse> CreateAsync(CreateProjectRequest request, CancellationToken cancellationToken)
    {
        var project = new Project
        {
            Titel = request.Titel.Trim(),
            Beschrijving = request.Beschrijving.Trim(),
            Categorie = request.Categorie.Trim(),
            GitHubUrl = request.GitHubUrl.Trim(),
            Datum = request.Datum!.Value,
            Status = request.Status.Trim(),
            Technologieen = CleanList(request.Technologieen),
            TechnischeDetails = CleanList(request.TechnischeDetails)
        };

        _dbContext.Projects.Add(project);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return ToResponse(project);
    }


    public async Task<bool> UpdateAsync(int id, UpdateProjectRequest request, CancellationToken cancellationToken)
    {
        var project = await _dbContext.Projects.FirstOrDefaultAsync(
            project => project.Id == id, cancellationToken);

        if (project is null)
        {
            return false;
        }

        project.Titel = request.Titel.Trim();
        project.Beschrijving = request.Beschrijving.Trim();
        project.Categorie = request.Categorie.Trim();
        project.GitHubUrl = request.GitHubUrl.Trim();
        project.Datum = request.Datum!.Value;
        project.Status = request.Status.Trim();
        project.Technologieen = CleanList(request.Technologieen);
        project.TechnischeDetails = CleanList(request.TechnischeDetails);

        await _dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var project = await _dbContext.Projects.FirstOrDefaultAsync(
            project => project.Id == id, cancellationToken);

        if (project is null)
        {
            return false;
        }

        _dbContext.Projects.Remove(project);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }

    private static ProjectResponse ToResponse(Project project) => new(
        project.Id,
        project.Titel,
        project.Beschrijving,
        project.Categorie,
        project.GitHubUrl,
        project.Datum,
        project.Status,
        project.Technologieen.ToList(),
        project.TechnischeDetails.ToList());

    private static List<string> CleanList(List<string>? values) =>
        values?.Where(value => !string.IsNullOrWhiteSpace(value))
               .Select(value => value.Trim())
               .ToList() ?? [];
}

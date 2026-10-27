using Microsoft.EntityFrameworkCore;
using PortfolioApi.Data;
using PortfolioApi.DTOs;
using PortfolioApi.Models;

namespace PortfolioApi.Services;

public sealed class BlogpostService : IBlogpostService
{
    private readonly PortfolioDbContext _dbContext;

    public BlogpostService(PortfolioDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IReadOnlyList<BlogpostResponse>> GetAllAsync(CancellationToken cancellationToken)
    {
        var blogposts = await _dbContext.Blogposts.AsNoTracking()
            .OrderByDescending(blogpost => blogpost.Publicatiedatum)
            .ThenBy(blogpost => blogpost.Id)
            .ToListAsync(cancellationToken);

        return blogposts.Select(ToResponse).ToList();
    }

    public async Task<BlogpostResponse?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var blogpost = await _dbContext.Blogposts.AsNoTracking()
            .FirstOrDefaultAsync(blogpost => blogpost.Id == id, cancellationToken);

        return blogpost is null ? null : ToResponse(blogpost);
    }

    public async Task<BlogpostResponse> CreateAsync(CreateBlogpostRequest request, CancellationToken cancellationToken)
    {
        var blogpost = new Blogpost
        {
            Titel = request.Titel.Trim(),
            Inhoud = request.Inhoud.Trim(),
            Publicatiedatum = request.Publicatiedatum!.Value
        };

        _dbContext.Blogposts.Add(blogpost);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return ToResponse(blogpost);
    }

    public async Task<bool> UpdateAsync(int id, UpdateBlogpostRequest request, CancellationToken cancellationToken)
    {
        var blogpost = await _dbContext.Blogposts.FirstOrDefaultAsync(
            blogpost => blogpost.Id == id, cancellationToken);

        if (blogpost is null)
        {
            return false;
        }

        blogpost.Titel = request.Titel.Trim();
        blogpost.Inhoud = request.Inhoud.Trim();
        blogpost.Publicatiedatum = request.Publicatiedatum!.Value;

        await _dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }


public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var blogpost = await _dbContext.Blogposts.FirstOrDefaultAsync(
            blogpost => blogpost.Id == id, cancellationToken);

        if (blogpost is null)
        {
            return false;
        }

        _dbContext.Blogposts.Remove(blogpost);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }

    private static BlogpostResponse ToResponse(Blogpost blogpost) => new(
        blogpost.Id,
        blogpost.Titel,
        blogpost.Inhoud,
        blogpost.Publicatiedatum);
}


using PortfolioApi.DTOs;

namespace PortfolioApi.Services;

public interface IBlogpostService
{
    Task<IReadOnlyList<BlogpostResponse>> GetAllAsync(
        CancellationToken cancellationToken);

    Task<BlogpostResponse?> GetByIdAsync(
        int id,
        CancellationToken cancellationToken);

    Task<BlogpostResponse> CreateAsync(
        CreateBlogpostRequest request,
        CancellationToken cancellationToken);

    Task<bool> UpdateAsync(
        int id,
        UpdateBlogpostRequest request,
        CancellationToken cancellationToken);

    Task<bool> DeleteAsync(
        int id,
        CancellationToken cancellationToken);
}

using Microsoft.AspNetCore.Mvc;
using PortfolioApi.DTOs;
using PortfolioApi.Services;

namespace PortfolioApi.Controllers;

[ApiController]
[Route("api/blogposts")]
public sealed class BlogpostsController : ControllerBase
{
    private readonly IBlogpostService _blogpostService;

    public BlogpostsController(IBlogpostService blogpostService)
    {
        _blogpostService = blogpostService;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<BlogpostResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var blogposts = await _blogpostService.GetAllAsync(cancellationToken);
        return Ok(blogposts);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BlogpostResponse>> GetById(int id, CancellationToken cancellationToken)
    {
        var blogpost = await _blogpostService.GetByIdAsync(id, cancellationToken);
        return blogpost is null ? NotFound() : Ok(blogpost);
    }

    [HttpPost]
    public async Task<ActionResult<BlogpostResponse>> Create(
        [FromBody] CreateBlogpostRequest request, CancellationToken cancellationToken)
    {
        var blogpost = await _blogpostService.CreateAsync(request, cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id = blogpost.Id }, blogpost);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(
        int id, [FromBody] UpdateBlogpostRequest request, CancellationToken cancellationToken)
    {
        var updated = await _blogpostService.UpdateAsync(id, request, cancellationToken);
        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        var deleted = await _blogpostService.DeleteAsync(id, cancellationToken);
        return deleted ? NoContent() : NotFound();
    }
}

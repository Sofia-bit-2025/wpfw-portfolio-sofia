
using Microsoft.AspNetCore.Http;
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
    [ProducesResponseType(typeof(IReadOnlyList<BlogpostResponse>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<BlogpostResponse>>> GetAll(
        CancellationToken cancellationToken)
    {
        var blogposts = await _blogpostService.GetAllAsync(cancellationToken);

        return Ok(blogposts);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(BlogpostResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<BlogpostResponse>> GetById(
        int id,
        CancellationToken cancellationToken)
    {
        var blogpost = await _blogpostService.GetByIdAsync(
            id,
            cancellationToken);

        return blogpost is null ? NotFound() : Ok(blogpost);
    }

    [HttpPost]
    [ProducesResponseType(typeof(BlogpostResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<BlogpostResponse>> Create(
        [FromBody] CreateBlogpostRequest request,
        CancellationToken cancellationToken)
    {
        var blogpost = await _blogpostService.CreateAsync(
            request,
            cancellationToken);

        return CreatedAtAction(
            nameof(GetById),
            new { id = blogpost.Id },
            blogpost);
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(
        int id,
        [FromBody] UpdateBlogpostRequest request,
        CancellationToken cancellationToken)
    {
        var updated = await _blogpostService.UpdateAsync(
            id,
            request,
            cancellationToken);

        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(
        int id,
        CancellationToken cancellationToken)
    {
        var deleted = await _blogpostService.DeleteAsync(
            id,
            cancellationToken);

        return deleted ? NoContent() : NotFound();
    }
}

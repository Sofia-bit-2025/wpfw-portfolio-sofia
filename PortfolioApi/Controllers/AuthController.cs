using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioApi.DTOs;

namespace PortfolioApi.Controllers;

[ApiController]
[Route("api/auth")]
public sealed class AuthController : ControllerBase
{
    private const string GuestRole = "Gast";

    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public AuthController(
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(
        [FromBody] RegisterRequest request)
    {
        var email = request.Email.Trim();

        var user = new IdentityUser
        {
            UserName = email,
            Email = email
        };

        var createResult = await _userManager.CreateAsync(
            user,
            request.Password);

        if (!createResult.Succeeded)
        {
            var errors = createResult.Errors
                .GroupBy(error => error.Code)
                .ToDictionary(
                    group => group.Key,
                    group => group
                        .Select(error => error.Description)
                        .ToArray());

            return ValidationProblem(errors);
        }

        var roleResult = await _userManager.AddToRoleAsync(
            user,
            GuestRole);

        if (!roleResult.Succeeded)
        {
            await _userManager.DeleteAsync(user);

            return Problem(
                detail: "De gebruikersrol kon niet worden ingesteld.",
                statusCode: StatusCodes.Status500InternalServerError);
        }

        return StatusCode(
            StatusCodes.Status201Created,
            new { message = "Registratie geslaagd." });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(
        [FromBody] LoginRequest request)
    {
        var email = request.Email.Trim();
        var user = await _userManager.FindByEmailAsync(email);

        if (user is null)
        {
            return InvalidLogin();
        }

        var signInResult = await _signInManager.PasswordSignInAsync(
            user,
            request.Password,
            isPersistent: false,
            lockoutOnFailure: true);

        if (!signInResult.Succeeded)
        {
            return InvalidLogin();
        }

        return Ok(new { message = "Login geslaagd." });
    }

    private IActionResult InvalidLogin()
    {
        return Unauthorized(new
        {
            message = "E-mailadres of wachtwoord is onjuist."
        });
    }
}

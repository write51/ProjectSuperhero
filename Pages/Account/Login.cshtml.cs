using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ProjectSuperhero.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; } = string.Empty;

        [BindProperty]
        public string Password { get; set; } = string.Empty;

        public string ReturnUrl { get; set; } = string.Empty;

        public void OnGet(string? returnUrl)
        {
            // If an unauthenticated user gets redirected here, remember where they wanted to go
            ReturnUrl = returnUrl ?? "/Admin/Comics/Index";
        }

        public async Task<IActionResult> OnPostAsync(string? returnUrl)
        {
            returnUrl ??= "/Admin/Comics/Index";

            // HARDCODED CREDENTIALS - Change these to your liking
            if (Username == "admin" && Password == "admin")
            {
                // Create identity credentials (Claims)
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Username),
                    new Claim(ClaimTypes.Role, "Administrator") // Matches the Program.cs policy
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                // Issue the cookie to the browser
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return LocalRedirect(returnUrl);
            }

            // If login fails
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return Page();
        }
    }
}
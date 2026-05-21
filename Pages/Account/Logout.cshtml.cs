using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace ProjectSuperhero.Pages.Account
{
    public class LogoutModel : PageModel
    {
        // This handles the HTTP POST request submitted by the navbar button
        public async Task<IActionResult> OnPostAsync()
        {
            // Wipes the authentication cookie cleanly out of the user's browser
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Redirect them safely back to the public homepage
            return RedirectToPage("/Index");
        }
    }
}
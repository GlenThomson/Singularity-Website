using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Singularity_Website.Pages
{
    public class LoginPageModel : PageModel
    {
        public void OnGet()
        {
            // Handle the GET request for the login page
        }

        public IActionResult OnPost()
        {
            // Handle the POST request when the form is submitted
            if (!ModelState.IsValid)
            {
                // If the form data is not valid, return the same page with validation errors
                return Page();
            }

            // Retrieve the submitted form data
            string email = Request.Form["email"];
            string password = Request.Form["password"];

            // Perform authentication logic
            bool isAuthenticated = PerformAuthentication(email, password);

            if (isAuthenticated)
            {
                // Redirect to a success page or perform additional actions
                return RedirectToPage("/Success");
            }
            else
            {
                // Add a model-level error message
                ModelState.AddModelError(string.Empty, "Invalid email or password");

                // Return the same page with the error message
                return Page();
            }
        }

        private bool PerformAuthentication(string email, string password)
        {
            // Implement your authentication logic here
            // Verify the credentials against a database or external authentication provider
            // Return true if the authentication is successful, false otherwise
            // You can use ASP.NET Core Identity or your own authentication mechanism
            // to handle the authentication process.
            // Example:
            // if (email == "validEmail" && password == "validPassword")
            // {
            //     return true;
            // }
            // else
            // {
            //     return false;
            // }
            return false;
        }
    }
}

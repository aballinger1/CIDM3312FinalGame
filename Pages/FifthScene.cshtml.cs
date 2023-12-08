using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnotherNightmare.Pages
{
    public class FifthSceneModel : PageModel
    {
        public void OnGet()
        {
            // Initialization logic for this scene
        }

        public IActionResult OnPost(string choice)
        {
            
            return RedirectToPage("/FinalScene", new { choice = choice });
        }
    }
}
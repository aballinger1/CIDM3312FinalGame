using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnotherNightmare.Pages
{
    public class FirstSceneModel : PageModel
    {
        public void OnGet()
        {
            // Initialization logic, if any
        }

        public IActionResult OnPost(int choice)
        {
            return RedirectToPage("/SecondScene", new { choiceId = choice });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnotherNightmare.Pages
{
    public class SecondSceneModel : PageModel
    {
        public void OnGet()
        {
            // Initialization logic for the second scene
        }

        public IActionResult OnPost(int choice)
        {
            var nextScene = GetNextScenePage(choice);
            return RedirectToPage(nextScene, new { choice = choice });
        }

        public string GetNextScenePage(int choice)
        {
            if (choice == 1 || choice == 4)
            {
                return "/FinalScene";
            }
            else
            {
                return "/ThirdScene";
            }
        }
    }
}
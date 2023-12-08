using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnotherNightmare.Pages
{
    public class ThirdSceneModel : PageModel
    {
        public void OnGet()
        {
            // Initialization logic for the second scene
        }

        public IActionResult OnPost(int choice)
        {
            var nextScene = GetNextScenePage1(choice);
            return RedirectToPage(nextScene, new { choice = choice });
        }

        public string GetNextScenePage1(int choice)
        {
            if (choice == 1 || choice == 4)
            {
                return "/FinalScene";
            }
            else
            {
                return "/FourthScene";
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;
using AnotherNightmare.Models;
using System.Linq;

namespace AnotherNightmare.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameContext(
                serviceProvider.GetRequiredService<DbContextOptions<GameContext>>()))
            {
                // Check if the database already has scenes seeded
                if (context.Scenes.Any())
                {
                    return; // DB has been seeded
                }

                // Initial scene where the player wakes up
                var initialScene = new Scene
                {
                    Text = "A knock at the door wakes you. You must have fallen asleep on the couch..."
                    // Add more details as necessary
                };
                context.Scenes.Add(initialScene);
                context.SaveChanges(); // Save to generate SceneID for initial scene

                // Create choices for the initial scene
                var choicesForInitialScene = new Choice[]
                {
                    new Choice { SceneID = initialScene.SceneID, Text = "Black coffee only. Thanks, Alex.", NextSceneID = null }, // NextSceneID to be assigned later
                    new Choice { SceneID = initialScene.SceneID, Text = "A couple of hardboiled eggs and toast with jam. Thanks, Alex.", NextSceneID = null },
                    // Add other choices here
                };

                context.Choices.AddRange(choicesForInitialScene);

                // Follow-up scenes for each choice
                var followUpScenes = new Scene[]
                {
                    new Scene { Text = "You take a sip of the black coffee, feeling its warmth." },
                    new Scene { Text = "You enjoy the hardboiled eggs and toast, feeling satisfied." },
                    // Add other follow-up scenes here
                };

                context.Scenes.AddRange(followUpScenes);
                context.SaveChanges(); // Save to generate SceneIDs for follow-up scenes

                // Now assign NextSceneID to choices
                choicesForInitialScene[0].NextSceneID = followUpScenes[0].SceneID;
                choicesForInitialScene[1].NextSceneID = followUpScenes[1].SceneID;
                // Repeat for other choices...

                // Save changes with updated NextSceneIDs
                context.SaveChanges();
            }
        }
    }
}
namespace AnotherNightmare.Models
{
    public class Choice
    {
        public int ChoiceID { get; set; } // Primary key
        public int SceneID { get; set; } // Foreign key to Scene
        public string? Text { get; set; } = string.Empty; // Text content of the choice, nullable
        public int? NextSceneID { get; set; } // ID of the next scene, nullable
        public Scene? Scene { get; set; } // Navigation property, nullable
    }
}
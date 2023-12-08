namespace AnotherNightmare.Models
{
    public class Scene
    {
        public int SceneID { get; set; } // Primary key
        public string? Text { get; set; } 
        public string? ImageURL { get; set; } 
        public List<Choice> Choices { get; set; } 
        public Scene()
        {
            Choices = new List<Choice>();
        }
    }
}
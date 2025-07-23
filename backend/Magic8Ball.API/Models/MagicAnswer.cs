namespace Magic8Ball.API.models
{
    public class MagicAnswer
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public required string Type { get; set; }
    }
}
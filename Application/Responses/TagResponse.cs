namespace Application.Responses
{
    public class TagResponse
    {
        public string Node_id { get; set; }
        public string Tag { get; set; }
        public string Sha { get; set; }
        public string Url { get; set; }
        public string Message { get; set; }
        public Tagger Tagger { get; set; }
        public ObjectGithub Object { get; set; }
        public Verification Verification { get; set; }
    }

    public class Tagger
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}

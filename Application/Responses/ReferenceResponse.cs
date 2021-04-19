namespace Application.Responses
{
    public class ReferenceResponse
    {
        public string Ref { get; set; }
        public string Node_id { get; set; }
        public string Url { get; set; }
        public ObjectGithub Object { get; set; }
    }

    public class ObjectGithub
    {
        public string Type { get; set; }
        public string Sha { get; set; }
        public string Url { get; set; }
    }
}

namespace Application.Responses
{
    public class ArtifactResponse
    {
        public int Id { get; set; }
        public string Node_id { get; set; }
        public string Name { get; set; }
        public int Size_in_bytes { get; set; }
        public string Url { get; set; }
        public string State { get; set; }
        public string Archive_download_url { get; set; }
        public bool Expired { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Expires_at { get; set; }
        public DateTime Updated_at { get; set; }
        public string Path { get; set; }
        public string Html_url { get; set; }
        public string Badge_url { get; set; }
    }
}

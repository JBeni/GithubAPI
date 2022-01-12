namespace Application.Responses
{
    public class GistResponse
    {
        public string Url { get; set; }
        public string Forks_url { get; set; }
        public string Commits_url { get; set; }
        public string Id { get; set; }
        public string Node_id { get; set; }
        public string Git_pull_url { get; set; }
        public string Git_push_url { get; set; }
        public string Html_url { get; set; }
        public bool Public { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public string Description { get; set; }
        public int Comments { get; set; }
        public string User { get; set; }
        public string Comments_url { get; set; }
        public Owner Owner { get; set; }
        public bool Truncated { get; set; }
    }

    public class Owner
    {
        public string Login { get; set; }
        public string Id { get; set; }
        public string Node_id { get; set; }
        public string Avatar_url { get; set; }
        public string Gravatar_id { get; set; }
        public string Url { get; set; }
        public string Html_url { get; set; }
        public string Followers_url { get; set; }
        public string Following_url { get; set; }
        public string Gists_url { get; set; }
        public string Starred_url { get; set; }
        public string Subscriptions_url { get; set; }
        public string Organizations_url { get; set; }
        public string Repos_url { get; set; }
        public string Events_url { get; set; }
        public string Received_events_url { get; set; }
        public string Type { get; set; }
        public bool Site_admin { get; set; }
    }

}

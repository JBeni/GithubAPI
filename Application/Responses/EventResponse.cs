using System;

namespace Application.Responses
{
    public class EventResponse
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public Actor Actor { get; set; }
        public Repo Repo { get; set; }
        public Payload Payload { get; set; }
        public bool Public { get; set; }
        public DateTime Created_at { get; set; }
    }

    public class Actor
    {
        public string Id { get; set; }
        public string Login { get; set; }
        public string Display_login { get; set; }
        public string Gravatar_id { get; set; }
        public string Url { get; set; }
        public string Avatar_url { get; set; }
    }

    public class Repo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Payload
    {
        public string Push_id { get; set; }
        public int Size { get; set; }
        public int Distinct_size { get; set; }
        public string Ref { get; set; }
        public string Head { get; set; }
        public string Before { get; set; }
    }

    public class Commit
    {
        public string Sha { get; set; }
        public Author Author { get; set; }
        public string Message { get; set; }
        public string Distinct { get; set; }
        public string Url { get; set; }
    }

    public class Author
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}

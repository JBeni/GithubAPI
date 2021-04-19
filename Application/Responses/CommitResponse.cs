using System;

namespace Application.Responses
{
    public class CommitResponse
    {
        public string Sha { get; set; }
        public string Node_id { get; set; }
        public string Url { get; set; }
        public string Html_url { get; set; }
        public AuthorCommit Author { get; set; }
        public Committer Committer { get; set; }
        public string Message { get; set; }
        public Tree Tree { get; set; }
        public string Parents { get; set; }
        public Verification Verification { get; set; }
    }

    public class AuthorCommit
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Committer
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class Tree
    {
        public string Url { get; set; }
        public string Sha { get; set; }
    }

    public class Parents
    {
        public string Url { get; set; }
        public string Sha { get; set; }
        public string Html_url { get; set; }
    }

    public class Verification
    {
        public bool Verified { get; set; }
        public string Reason { get; set; }
        public string Signature { get; set; }
        public string Payload { get; set; }
    }
}

using System.Collections.Generic;

namespace Application.Responses
{
    public class LicensesResponse
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Spdx_id { get; set; }
        public string Url { get; set; }
        public string Node_id { get; set; }
        public string Html_url { get; set; }
    }

    public class LicenseResponse
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Spdx_id { get; set; }
        public string Url { get; set; }
        public string Node_id { get; set; }
        public string Html_url { get; set; }
        public string Description { get; set; }
        public string Implementation { get; set; }
        public List<string> Permissions { get; set; }
        public List<string> Conditions { get; set; }
        public List<string> Limitations { get; set; }
        public string Body { get; set; }
        public bool Featured { get; set; }
    }

    public class RepositoryLicenseResponse
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Sha { get; set; }
        public int Size { get; set; }
        public string Url { get; set; }
        public string Html_url { get; set; }
        public string Git_url { get; set; }
        public string Download_url { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public string Encoding { get; set; }
        public Links _Links { get; set; }
        public License License { get; set; }
    }

    public class Links
    {
        public string Self { get; set; }
        public string Git { get; set; }
        public string Html { get; set; }
    }

    public class License
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Spdx_id { get; set; }
        public string Url { get; set; }
        public string Node_id { get; set; }
    }
}

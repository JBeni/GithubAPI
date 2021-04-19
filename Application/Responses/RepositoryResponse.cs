﻿using System;
using System.Collections.Generic;

namespace Application.Responses
{
    public class RepositoryResponse
    {
        public int Id { get; set; }
        public string Node_id { get; set; }
        public string Name { get; set; }
        public string Full_name { get; set; }
        public Owner Owner { get; set; }
        public bool Private { get; set; }
        public string Html_url { get; set; }
        public string Description { get; set; }
        public bool Fork { get; set; }
        public string Url { get; set; }
        public string Archive_url { get; set; }
        public string Assignees_url { get; set; }
        public string Blobs_url { get; set; }
        public string Branches_url { get; set; }
        public string Collaborators_url { get; set; }
        public string Comments_url { get; set; }
        public string Commits_url { get; set; }
        public string Compare_url { get; set; }
        public string Contents_url { get; set; }
        public string Contributors_url { get; set; }
        public string Deployments_url { get; set; }
        public string Downloads_url { get; set; }
        public string Events_url { get; set; }
        public string Forks_url { get; set; }
        public string Git_commits_url { get; set; }
        public string Git_refs_url { get; set; }
        public string Git_tags_url { get; set; }
        public string Git_url { get; set; }
        public string Issue_comment_url { get; set; }
        public string Issue_events_url { get; set; }
        public string Issues_url { get; set; }
        public string Keys_url { get; set; }
        public string Labels_url { get; set; }
        public string Languages_url { get; set; }
        public string Merges_url { get; set; }
        public string Milestones_url { get; set; }
        public string Notifications_url { get; set; }
        public string Pulls_url { get; set; }
        public string Releases_url { get; set; }
        public string Ssh_url { get; set; }
        public string Stargazers_url { get; set; }
        public string Statuses_url { get; set; }
        public string Subscribers_url { get; set; }
        public string Subscription_url { get; set; }
        public string Tags_url { get; set; }
        public string Teams_url { get; set; }
        public string Trees_url { get; set; }
        public string Clone_url { get; set; }
        public string Mirror_url { get; set; }
        public string Hooks_url { get; set; }
        public string Svn_url { get; set; }
        public string Homepage { get; set; }
        public string Language { get; set; }
        public int Forks_count { get; set; }
        public int Stargazers_coun { get; set; }
        public int Watchers_count { get; set; }
        public int Size { get; set; }
        public string Default_branch { get; set; }
        public int Open_issues_count { get; set; }
        public bool Is_template { get; set; }
        public bool Has_issues { get; set; }
        public bool Has_projects { get; set; }
        public bool Has_wiki { get; set; }
        public bool Has_pages { get; set; }
        public bool Has_downloads { get; set; }
        public bool Archived { get; set; }
        public bool Disabled { get; set; }
        public bool Visibility { get; set; }
        public DateTime Pushed_at { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public bool Allow_rebase_merge { get; set; }
        public string Temp_clone_token { get; set; }
        public bool Allow_squash_merge { get; set; }
        public bool Delete_branch_on_merge { get; set; }
        public bool Allow_merge_commit { get; set; }
        public int Subscribers_count { get; set; }
        public int Network_count { get; set; }
        public int Forks { get; set; }
        public int Open_issues { get; set; }
        public int Watchers { get; set; }
        public List<string> Topics { get; set; }
        public Permission Permission { get; set; }
        public TemplateRepository Template_repository { get; set; }
    }

    public class TemplateRepository
    {
        public int Id { get; set; }
        public string Node_id { get; set; }
        public string Name { get; set; }
        public string Full_name { get; set; }
        public Owner Owner { get; set; }
        public bool Private { get; set; }
        public string Html_url { get; set; }
        public string Description { get; set; }
        public bool Fork { get; set; }
        public string Url { get; set; }
        public string Archive_url { get; set; }
        public string Assignees_url { get; set; }
        public string Blobs_url { get; set; }
        public string Branches_url { get; set; }
        public string Collaborators_url { get; set; }
        public string Comments_url { get; set; }
        public string Commits_url { get; set; }
        public string Compare_url { get; set; }
        public string Contents_url { get; set; }
        public string Contributors_url { get; set; }
        public string Deployments_url { get; set; }
        public string Downloads_url { get; set; }
        public string Events_url { get; set; }
        public string Forks_url { get; set; }
        public string Git_commits_url { get; set; }
        public string Git_refs_url { get; set; }
        public string Git_tags_url { get; set; }
        public string Git_url { get; set; }
        public string Issue_comment_url { get; set; }
        public string Issue_events_url { get; set; }
        public string Issues_url { get; set; }
        public string Keys_url { get; set; }
        public string Labels_url { get; set; }
        public string Languages_url { get; set; }
        public string Merges_url { get; set; }
        public string Milestones_url { get; set; }
        public string Notifications_url { get; set; }
        public string Pulls_url { get; set; }
        public string Releases_url { get; set; }
        public string Ssh_url { get; set; }
        public string Stargazers_url { get; set; }
        public string Statuses_url { get; set; }
        public string Subscribers_url { get; set; }
        public string Subscription_url { get; set; }
        public string Tags_url { get; set; }
        public string Teams_url { get; set; }
        public string Trees_url { get; set; }
        public string Clone_url { get; set; }
        public string Mirror_url { get; set; }
        public string Hooks_url { get; set; }
        public string Svn_url { get; set; }
        public string Homepage { get; set; }
        public string Language { get; set; }
        public int Forks_count { get; set; }
        public int Stargazers_coun { get; set; }
        public int Watchers_count { get; set; }
        public int Size { get; set; }
        public string Default_branch { get; set; }
        public int Open_issues_count { get; set; }
        public bool Is_template { get; set; }
        public List<string> Topics { get; set; }
        public bool Has_issues { get; set; }
        public bool Has_projects { get; set; }
        public bool Has_wiki { get; set; }
        public bool Has_pages { get; set; }
        public bool Has_downloads { get; set; }
        public bool Archived { get; set; }
        public bool Disabled { get; set; }
        public bool Visibility { get; set; }
        public DateTime Pushed_at { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public Permission Permissions { get; set; }
        public bool Allow_rebase_merge { get; set; }
        public string Template_repository { get; set; }
        public string Temp_clone_token { get; set; }
        public bool Allow_squash_merge { get; set; }
        public bool Delete_branch_on_merge { get; set; }
        public bool Allow_merge_commit { get; set; }
        public int Subscribers_count { get; set; }
        public int Network_count { get; set; }
        public License License { get; set; }
        public int Forks { get; set; }
        public int Open_issues { get; set; }
        public int Watchers { get; set; }
    }

    public class BranchResponse
    {
        public string Name { get; set; }
        public Commit Commit { get; set; }
        public bool Protected { get; set; }
        public Protection Protection { get; set; }
        public string Protection_url { get; set; }
    }

    public class Protection
    {
        public string Required_status_checks { get; set; }
    }

    public class RequiredStatusCheck
    {
        public string Enforcement_level { get; set; }
        public List<string> Contexts { get; set; }
    }
}

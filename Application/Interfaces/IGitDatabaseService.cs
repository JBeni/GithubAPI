﻿using Application.Handlers.GitDatabases.Queries;
using Application.Responses;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGitDatabaseService
    {
        Task<BlobResponse> GetBlob(GetBlobQuery query);
        Task<CommitResponse> GetCommit(GetCommitQuery query);
        Task<ReferenceResponse> GetReference(GetReferenceQuery query);
        Task<TagResponse> GetTag(GetTagQuery query);
    }
}

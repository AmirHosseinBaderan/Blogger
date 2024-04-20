﻿using Blogger.Application.Usecases.GetApprovedArticleComments;

namespace Blogger.APIs.Contracts.GetApprovedArticleComments;

public class GetApprovedArticleCommentsMappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.ForType<GetApprovedArticleCommentsRequest, GetApprovedArticleCommentsQuery>()
                   .Map(x => x.ArticleId, src => ArticleId.Create(src.ArticleId));

        config.ForType<GetApprovedArticleCommentsResponse, GetApprovedArticleCommentsQueryResponse>();
    }
}
using NS.Domain.Models.View;
using System;
using System.Collections.Generic;

namespace NS.Domain.Contracts.Services
{
    public interface IMainService : IDisposable
    {
        List<PostsVM> GetPosts();
    }
}

using NS.Domain.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.Domain.Contracts.Repositories
{
    public interface IMainRepository
    {
        List<PostsVM> GetPosts();
    }
}

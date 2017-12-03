using NS.Domain.Contracts.Services;
using NS.Domain.Contracts.UnitOfWork;
using NS.Domain.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.Business
{
    public class MainService : IMainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<PostsVM> GetPosts()
        {
            return _unitOfWork.MainRepository.GetPosts();
        }

        public void Dispose()
        {
            
        }
    }
}

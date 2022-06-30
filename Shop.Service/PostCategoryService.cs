using Shop.Data.Infrastructure;
using Shop.Data.Repository;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory post);
        void Update(PostCategory post);
        void Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllPaging(int page, int pageSize, out int TotalRow);
        PostCategory GetByID(int id);
        IEnumerable<PostCategory> GetAllTagPaging(string tag, int page, int pageSize, out int TotalRow);
        void SaveChange();
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepo;
        private IUnitOfWork _unitOfWork;
        public void Add(PostCategory post)
        {
            _postCategoryRepo.Add(post);
        }

        public void Delete(int id)
        {
            _postCategoryRepo.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRepo.GetAll();
        }

        public IEnumerable<PostCategory> GetAllPaging(int page, int pageSize, out int TotalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostCategory> GetAllTagPaging(string tag, int page, int pageSize, out int TotalRow)
        {
            throw new NotImplementedException();
        }

        public PostCategory GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory post)
        {
            throw new NotImplementedException();
        }
    }
}

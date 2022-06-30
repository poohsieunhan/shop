using Shop.Data.Infrastructure;
using Shop.Data.Repository;
using Shop.Model.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int TotalRow);
        Post GetByID(int id);
        IEnumerable<Post> GetAllTagPaging(string tag,int page, int pageSize, out int TotalRow);
        void SaveChange();
    }

    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll();
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int TotalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out TotalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllTagPaging(string tag,int page, int pageSize, out int TotalRow)
        {
            //TODO: select page by status
            return _postRepository.GetAllByTag(tag,page,pageSize, out TotalRow);

        }

   


        public Post GetByID(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }


    }
}

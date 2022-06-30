using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.Data.Infrastructure;
using Shop.Data.Repository;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.UnitTest.Repository_Test
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repo_Create()
        {
            PostCategory pc = new PostCategory();
            pc.Name = "test pc";
            pc.Alias = "test pc";
            pc.Status = true;
            var result = objRepository.Add(pc);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result);
        }
    }
}

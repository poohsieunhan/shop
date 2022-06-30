using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string _alias);
    }

    public class ProductCategoryRepository: RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(DbFactory dbFactory)
            :base(dbFactory)
        {

        }

        public IEnumerable<ProductCategory>GetByAlias(string _alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == _alias);
        }
    }
}

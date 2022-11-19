using Core.Model;
using Data.Abstract;
using Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramework
{
    public class EfProduct : RepositoryBase<Product,Context>, IProductDal
    {
      
    }
}

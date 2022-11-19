using Core.Model;
using Data.Abstract;
using Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramework
{
    public class EfCategory : RepositoryBase<Category, Context>, ICategoryDal
    {
    }
}

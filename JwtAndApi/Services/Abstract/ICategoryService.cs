using Core.Model;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int category);

        IDataResult<List<Category>> GetList();

        IDataResult<List<Category>> GetByCategory(int category);

        IResult Add(Category category);

        IResult Delete(Category category);

        IResult Update(Category category);
    }
}

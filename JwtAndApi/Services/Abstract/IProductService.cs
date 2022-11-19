using Core.Model;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int ProductId);

        IDataResult<List<Product>> GetList();

        IDataResult<List<Product>> GetByCategory(int CategpryId);

        IResult Add(Product product);

        IResult Delete(Product product);

        IResult Update(Product product);





    }
}

using Core.Model;
using Core.Utilities.Results;
using Data.Abstract;
using Services.Abstract;
using Services.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal  categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<Category> GetById(int category)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.Id == category));
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }

        public IDataResult<List<Category>> GetByCategory(int category)
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList(p => p.Id == category).ToList());
        }

        public IResult Add(Category category)
        {
            //Business codes
            _categoryDal.Add(category);

            return new SuccessResult(Messager.ProductAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messager.ProductDeleted);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messager.ProductUpdated);
        }

    }
}

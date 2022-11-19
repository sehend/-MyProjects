using Core.Model;
using Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace JwtAndApi.Controllers
{
    public class CategorysController : Controller
    {
        ICategoryService _categoryDal;

        public CategorysController(ICategoryService category)
        {
            _categoryDal = category;
        }

        [HttpGet("CategoryGetAll")]
        public IActionResult GetList()
        {
            var result = _categoryDal.GetList();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);

        }

        [HttpGet("GetByCategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _categoryDal.GetByCategory(categoryId);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);

        }

        [HttpGet("CategoryGetById")]
        public IActionResult Get(int CategoryId)
        {
            var result = _categoryDal.GetById(CategoryId);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);

        }

        [HttpPost("CategoryAdd")]
        public IActionResult Add(Category category)
        {
            var result = _categoryDal.Add(category);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);

        }

        [HttpPost("CategoryUpdate")]
        public IActionResult Update(Category category)
        {
            var result = _categoryDal.Update(category);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);

        }

        [HttpPost("CategoryDelete")]
        public IActionResult Delete(Category category)
        {
            var result = _categoryDal.Delete(category);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);

        }
    }
}

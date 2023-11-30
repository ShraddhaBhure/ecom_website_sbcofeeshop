using cofee.repo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace coffee_shop_app.Controllers
{
    public class ProductController : Controller
	{
		private readonly IProductRepository _productRepo;
		public ProductController(IProductRepository productRepo)
		{
			_productRepo = productRepo;


		}

		public IActionResult Shop()
		{
			return View(_productRepo.GetAllProducts());
		}
      
        public IActionResult Detail(int id)
        {
            var product = _productRepo.GetProductDetail(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartStock.BLL.DTOs.ProductType;
using SmartStock.BLL.Mappers;
using SmartStock.BLL.Services;
using SmartStock.BLL.ViewModels.ProductType;

namespace SmartStock.WEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public async Task<IActionResult> IndexAsync()
        {
            // make it paged
            IEnumerable<ProductViewModel> products = Mapper<ProductDto, ProductViewModel>.MapAll(await _productService.GetAllAsync());
            return products != null ? View(products) : NotFound();
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = Mapper<ProductDto, ProductViewModel>.Map(await _productService.GetAsync(id));
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Stock")] ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateAsync(Mapper<ProductViewModel, ProductDto>.Map(product));
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = Mapper<ProductDto, ProductViewModel>.Map(await _productService.GetAsync(id));
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Stock,OrderProducts")] ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                await _productService.UpdateAsync(Mapper<ProductViewModel, ProductDto>.Map(product));
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var product = Mapper<ProductDto, ProductViewModel>.Map(await _productService.GetAsync(id));
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _productService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
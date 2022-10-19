using PCAD7_Assignment12_1.Models;
using PCAD7_Assignment12_1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace PCAD7_Assignment12_1.Controllers
{
    //Step 6. Add Product controller
    //Step 7. Add Product folder for views
    //Step 8. Inject Service
    public class ProductController : Controller
    {
        private IProduct iproduct;
        private IFileUploadService fileUploadService;
        public ProductController(IProduct iproduct, IFileUploadService fileUploadService)
        {
            this.iproduct = iproduct;
            this.fileUploadService = fileUploadService;
        }
        // Step 9. Write indexmodel and logic in index method
        // Step 10. add index view in product folder
        [Authorize(Roles = "Customer")]
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products= iproduct.GetProducts();
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            Product product = new Product();
            product.Id = iproduct.GetMaxId();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Create(Product obj, IFormFile file)
        {
            if(ModelState.IsValid)
            {
                if(await fileUploadService.UploadFile(file))
                {
                    obj.imageName = fileUploadService.FileName;
                    iproduct.AddProduct(obj);
                    return RedirectToRoute(new { Action = "Index", Controller = "Product" });
                }
                else
                {
                    ViewBag.ErrorMessage = "File Upload failed";
                    return View(obj);
                }
            }
            ViewBag.Message = "Error editing product..";
            return View(obj);
        }

        [Authorize(Roles = "Customer")]
        public IActionResult Details(int? id)
        {
            var pdct = iproduct.GetProduct(id);
            if(pdct == null)
            {
                return NotFound();
            }
            return View(pdct);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var pdct = iproduct.GetProduct(id);
            return View(pdct);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(Product obj)
        {
            if(ModelState.IsValid)
            {
                iproduct.UpdateProduct(obj);
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Error editing product..";
            return View(obj);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            iproduct.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}

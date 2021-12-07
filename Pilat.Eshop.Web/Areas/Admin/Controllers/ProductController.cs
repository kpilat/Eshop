using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pilat.Eshop.Web.Models.Database;
using Pilat.Eshop.Web.Models.Entity;
using Pilat.Eshop.Web.Models.Implementation;
using Microsoft.AspNetCore.Authorization;
using Pilat.Eshop.Web.Models.Identity;

namespace Pilat.Eshop.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + ", " + nameof(Roles.Manager))]
    public class ProductController : Controller
    {
        readonly EshopDbContext eshopDbContext;
        IWebHostEnvironment env;
        public ProductController(EshopDbContext eshopDB, IWebHostEnvironment env)
        {
            eshopDbContext = eshopDB;
            this.env = env;
        }

        private IList<Product> fillRelatedList()
        {
            IList<Product> products = eshopDbContext.Products.ToList();
            foreach (var product in products)
            {
                List<string> pRelated = new List<string>();
                if (product.Related != null)
                {
                    pRelated = product.Related.Split(',').ToList();
                    pRelated.RemoveAll(item => item == "");
                    product.RelatedList = pRelated;
                }
            }
            return products;
        }
        public IActionResult Select()
        {
            var products = fillRelatedList();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            var allProducts = fillRelatedList();
            Product requestedProduct = allProducts.FirstOrDefault(p => p.ID == id);
            List<Product> relatedProducts = new List<Product>();
            
            if (requestedProduct is {RelatedList: { }})
            {
                foreach (var item in requestedProduct.RelatedList)
                {
                    relatedProducts.AddRange(eshopDbContext.Products.Where(p => p.Category.Equals(item)).ToList());
                }
            }

            var tuple = new Tuple<Product, List<Product>>(requestedProduct, relatedProducts);
            return View(tuple);
        }
        public async Task<IActionResult> Related([FromQuery(Name = "product-id")] string id, [FromQuery(Name = "related")] string category)
        {
            Product product = eshopDbContext.Products.FirstOrDefault(p => p.ID == Int32.Parse(id));
            List<string> pRelated = new List<string>();
            if (product.Related != null)
            {
                pRelated = product.Related.Split(',').ToList();
                pRelated.RemoveAll(item => item == "");
            }

            if (pRelated.Contains(category))
                pRelated.Remove(category);
            else
                pRelated.Add(category);

            product.RelatedList = pRelated;
            string toUpload = "";
            pRelated.ForEach(item => toUpload += item + ",");
            product.Related = toUpload;
            await eshopDbContext.SaveChangesAsync();
            
            return RedirectToAction(nameof(CarouselController.Select));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product carouselItem)
        {
            if (carouselItem != null && carouselItem.Image != null)
            {
                FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/ProductItems", "image");
                carouselItem.ImageSource = await fileUpload.FileUploadAsync(carouselItem.Image);
                if (String.IsNullOrWhiteSpace(carouselItem.ImageSource) == false)
                {
                    /*if(eshopDbContext.CarouselItems!=null && eshopDbContext.CarouselItems.Count > 0)
                    {
                        carouselItem.ID = eshopDbContext.CarouselItems.Last().ID + 1;
                    }*/
                    eshopDbContext.Products.Add(carouselItem);
                    await eshopDbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(ProductController.Select));
                }
            }
            /*
            else
            {
            }*/
            return View(carouselItem);
        }
        public IActionResult Edit(int ID)
        {
            Product cifromDb = eshopDbContext.Products.FirstOrDefault(ci => ci.ID == ID);
            if (cifromDb != null)
            {
                return View(cifromDb);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product carouselItem)
        {
            Product cifromDb = eshopDbContext.Products.FirstOrDefault(ci => ci.ID == carouselItem.ID);
            if (cifromDb != null)
            {

                if (carouselItem != null && carouselItem.Image != null)
                {
                    FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/ProductItems", "image");
                    carouselItem.ImageSource = await fileUpload.FileUploadAsync(carouselItem.Image);

                    if (String.IsNullOrWhiteSpace(carouselItem.ImageSource) == false)
                    {
                        cifromDb.ImageSource = carouselItem.ImageSource;
                    }
                }
                cifromDb.ImageAlt = carouselItem.ImageAlt;
                cifromDb.Name = carouselItem.Name;
                cifromDb.Price = carouselItem.Price;
                await eshopDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(CarouselController.Select));
            }
            else
            {
                return NotFound();
            }
        }
        public async Task<IActionResult> Delete(int ID)
        {
            DbSet<Product> carouselItems = eshopDbContext.Products;
            Product ci = carouselItems.Where(CarouselItem => CarouselItem.ID == ID).FirstOrDefault();
            if (ci != null)
            {
                carouselItems.Remove(ci);
                await eshopDbContext.SaveChangesAsync();
            }
            //return View();
            return RedirectToAction(nameof(CarouselController.Select));
        }

        [HttpPost]
        public async Task<IActionResult> Detail(Product carouselItem)
        {
            Product cifromDb = eshopDbContext.Products.FirstOrDefault(ci => ci.ID == carouselItem.ID);
            if (cifromDb != null)
            {

                if (carouselItem != null && carouselItem.Image != null)
                {
                    FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/ProductItems", "image");
                    carouselItem.ImageSource = await fileUpload.FileUploadAsync(carouselItem.Image);

                    if (String.IsNullOrWhiteSpace(carouselItem.ImageSource) == false)
                    {
                        cifromDb.ImageSource = carouselItem.ImageSource;
                    }
                }
                cifromDb.ImageAlt = carouselItem.ImageAlt;
                cifromDb.Name = carouselItem.Name;
                cifromDb.Price = carouselItem.Price;
                await eshopDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(CarouselController.Select));
            }
            else
            {
                return NotFound();
            }
        }
    }
}

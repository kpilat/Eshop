using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Pilat.Eshop.Web.Models.Database;
using Pilat.Eshop.Web.Models.Entity;

namespace Pilat.Eshop.Web.Controllers
{
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
        
        // GET

        public IActionResult Detail(int id)
        {
            var allProducts = fillRelatedList();
            Product requestedProduct = allProducts.FirstOrDefault(p => p.ID == id);
            List<Product> relatedProducts = new List<Product>();
            
            if (requestedProduct is {RelatedList: { }})
            {
                foreach (var item in requestedProduct.RelatedList)
                {
                    //object eshopDbContext;
                    relatedProducts.AddRange(eshopDbContext.Products.Where(p => p.Category.Equals(item)).ToList());
                }
            }

            var tuple = new Tuple<Product, List<Product>>(requestedProduct, relatedProducts);
            return View(tuple);
        }
    }
}
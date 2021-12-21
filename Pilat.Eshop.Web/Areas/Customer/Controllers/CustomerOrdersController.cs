using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pilat.Eshop.Web.Models.ApplicationServices.Abstraction;
using Pilat.Eshop.Web.Models.Database;
using Pilat.Eshop.Web.Models.Entity;
using Pilat.Eshop.Web.Models.Extensions;
using Pilat.Eshop.Web.Models.Identity;
using Pilat.Eshop.Web.Models.ViewModels;

namespace Pilat.Eshop.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = nameof(Roles.Customer))]
    public class CustomerOrdersController : Controller
    {
        const string totalPriceString = "TotalPrice";
        const string orderItemsString = "OrderItems";
        
        ISecurityApplicationService iSecure;
        EshopDbContext eshopDbContext;
        public CustomerOrdersController(EshopDbContext eshopDbContext, ISecurityApplicationService iSecure)
        {
            this.iSecure = iSecure;
            this.eshopDbContext = eshopDbContext;
        }
        
        // GET
        public IActionResult Select()
        {
            IndexViewModel viewModel = new IndexViewModel();
            viewModel.Orders = eshopDbContext.Orders.ToList();
            return View(viewModel);
        }

        [HttpPost]
        public double AddOrderItemsToSession(int? productId)
        {
            double totalPrice = 0;
            if (HttpContext.Session.IsAvailable)
            {
                totalPrice = HttpContext.Session.GetDouble(totalPriceString).GetValueOrDefault();
            }


            Product product = eshopDbContext.Products.FirstOrDefault(prod => prod.ID == productId);

            if (product != null)
            {
                OrderItem orderItem = new OrderItem()
                {
                    ProductID = product.ID,
                    Product = product,
                    Amount = 1,
                    Price = product.Price   //zde pozor na datový typ -> pokud máte Price v obou případech double nebo decimal, tak je to OK. Mě se bohužel povedlo mít to jednou jako decimal a jednou jako double. Nejlepší je datový typ změnit v databázi/třídě, tak to prosím udělejte.
                };

                if (HttpContext.Session.IsAvailable)
                {

                    List<OrderItem> orderItems = HttpContext.Session.GetObject<List<OrderItem>>(orderItemsString);
                    OrderItem orderItemInSession = null;
                    if (orderItems != null)
                        orderItemInSession = orderItems.Find(oi => oi.ProductID == orderItem.ProductID);
                    else
                        orderItems = new List<OrderItem>();


                    if (orderItemInSession != null)
                    {
                        ++orderItemInSession.Amount;
                        orderItemInSession.Price += orderItem.Product.Price;   //zde pozor na datový typ -> pokud máte Price v obou případech double nebo decimal, tak je to OK. Mě se bohužel povedlo mít to jednou jako decimal a jednou jako double. Nejlepší je datový typ změnit v databázi/třídě, tak to prosím udělejte.
                    }
                    else
                    {
                        orderItems.Add(orderItem);
                    }


                    HttpContext.Session.SetObject(orderItemsString, orderItems);

                    totalPrice += orderItem.Product.Price;
                    HttpContext.Session.SetDouble(totalPriceString, totalPrice);
                }
            }


            return totalPrice;
        }
        
                [HttpPost]
        public double getCartValue()
        {
            double totalPrice = 0;
            if (HttpContext.Session.IsAvailable)
            {
                totalPrice = HttpContext.Session.GetDouble(totalPriceString).GetValueOrDefault();
            }
            return totalPrice;
        }
    }
}
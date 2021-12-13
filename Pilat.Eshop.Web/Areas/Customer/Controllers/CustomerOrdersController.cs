using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pilat.Eshop.Web.Models.Database;
using Pilat.Eshop.Web.Models.ViewModels;

namespace Pilat.Eshop.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CustomerOrdersController : Controller
    {
        private readonly EshopDbContext _eshopDbContext;

        public CustomerOrdersController(EshopDbContext eshopDb)
        {
            _eshopDbContext = eshopDb;
        }
        
        // GET
        public IActionResult Select()
        {
            IndexViewModel viewModel = new IndexViewModel();
            viewModel.Orders = _eshopDbContext.Orders.ToList();
            return View(viewModel);
        }

        // public IActionResult AddOrderItemsToSession()
        // {
        //     return View();
        // }
    }
}
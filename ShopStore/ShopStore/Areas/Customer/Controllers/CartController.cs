using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopStore.DataAccess.Data.Repository;
using ShopStore.Extensions;
using ShopStore.Models;
using ShopStore.Models.ViewModels;
using ShopStore.Utility;

namespace ShopStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        [BindProperty]
        public CartViewModel CartVM { get; set; }

        public CartController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            CartVM = new CartViewModel()
            {
                OrderHeader = new Models.OrderHeader(),
                ServiceList = new List<Service>()
            };
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetObject<List<int>>(SD.SessionCart)!=null)
            {
                List<int> sessionList = new List<int>();
                sessionList = HttpContext.Session.GetObject<List<int>>(SD.SessionCart);
                foreach (int serviceId in _unitOfWork)
                {

                }
            }
            return View();
        }
    }
}
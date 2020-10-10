using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopStore.DataAccess.Data.Repository.IRepository;

namespace ShopStore.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        private readonly IUnitOfWork _unitOfWork;
        public IActionResult Index()
        {
            return View();
        }

        #region API CALLS
        #endregion
    }
}
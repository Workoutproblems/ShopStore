﻿using Microsoft.AspNetCore.Mvc.Rendering;
using ShopStore.DataAccess.Data.Repository.IRepository;
using ShopStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopStore.DataAccess.Data.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        //public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        //{
        //    return _db.Category.Select(i => new SelectListItem()
        //    {
        //        Text = i.Name,
        //        Value = i.Id.ToString()
        //    });
        //}

        //public void Update(Category category)
        //{
        //    var objFromDb = _db.Category.FirstOrDefault(s => s.Id == category.Id);

        //    objFromDb.Name = category.Name;
        //    objFromDb.DisplayOrder = category.DisplayOrder;

        //    _db.SaveChanges();

        //}
    }
}

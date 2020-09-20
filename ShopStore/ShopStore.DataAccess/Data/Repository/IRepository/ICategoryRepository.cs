using Microsoft.AspNetCore.Mvc.Rendering;
using ShopStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopStore.DataAccess.Data.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();
        void Update(Category category);
    }
}

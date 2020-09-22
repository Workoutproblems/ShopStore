using Microsoft.AspNetCore.Mvc.Rendering;
using ShopStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopStore.DataAccess.Data.Repository.IRepository
{
    public interface IServiceRepository : IRepository<Service>
    {
        void Update(Service service);
    }
}

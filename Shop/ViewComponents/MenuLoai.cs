using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.ViewComponents
{
    public class MenuLoai:ViewComponent
    {
        private readonly MyDbContext ctx;

        public MenuLoai(MyDbContext db)
        {
            ctx = db;

            //Thực hiện tạo thư mục trong Shared /Components/MenuLoai theo đúng tên đã tạo
            //https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-2.2
            //Views/Shared/Components/{View Component Name}/{View Name} 
        }

        public IViewComponentResult Invoke()
        {
            return View(ctx.Loais);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Shop.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoa { get; set; }

        public MyDbContext(DbContextOptions options):base(options)
        {
            //1 Add-Migration v1 " v1: phiên bản của codefirst
            //2 Update-Database

            //để hiện diagram trong sql serverr
            /*
            USE MyShop
            GO
                ALTER DATABASE MyShop set TRUSTWORTHY ON;
            GO
                EXEC dbo.sp_changedbowner @loginame = N'sa', @map = false
            GO
                sp_configure 'show advanced options', 1;
            GO
                RECONFIGURE;
            GO
                sp_configure 'clr enabled', 1;
            GO
                RECONFIGURE;
            GO
            */


        }

        public MyDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //chỉ định loại CSDL dùng và chuỗi kết nối
            //đọc chuỗi kết nối từ appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("MyShop"));
            //optionsBuilder.UseSqlServer("Server=.; Database=EFCodeFirst; Integrated Security=True;");    
        }
    }
}

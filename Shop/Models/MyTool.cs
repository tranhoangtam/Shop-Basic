using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Shop.Models
{
    public class MyTool
    {
        public static string UploadHinh(IFormFile fHinh, string folder)
        {
            string fileNameReturn = string.Empty;
            if (fHinh != null)
            {
                fileNameReturn = $"_{DateTime.Now.Ticks}{fHinh.FileName}";
                var filename = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", folder, fileNameReturn);
                using (var file=new FileStream(filename,FileMode.Create))
                {
                    fHinh.CopyTo(file);
                    file.Flush();
                }
            }
            return fileNameReturn;
        }
    }
}

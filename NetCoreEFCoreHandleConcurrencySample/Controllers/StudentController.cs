using Microsoft.AspNetCore.Mvc;
using NetCoreEFCoreHandleConcurrencySample.Models;

namespace NetCoreEFCoreHandleConcurrencySample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbcontext;

        public StudentController(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        [HttpGet(nameof(NewData))]
        public IActionResult NewData()
        {
            // [DbContext 的存留期、設定與初始化 - EF Core | Microsoft Learn](https://learn.microsoft.com/zh-tw/ef/core/dbcontext-configuration/#simple-dbcontext-initialization-with-new)
                
            var std = new Student()
            {
                StudentName = "Bill"
            };

            _dbcontext.Students.Add(std);
            _dbcontext.SaveChanges();

            std.StudentName = "Steve";
            _dbcontext.SaveChanges();

            return Json(std);
        }
    }
}

using ECommerceMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace ECommerceMVC.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly Hshop2023Context db;

        public KhachHangController(Hshop2023Context context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DangKy(Register model)
        {
            if (ModelState.IsValid)
            {
                var KhachHang = model;
            }
            return View();
        }
    }
}

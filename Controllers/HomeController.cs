using DoAn3.Models;
using DoAn3.Models.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Discovery;

namespace DoAn3.Controllers
{
    public class HomeController : Controller
    {
        public LoaiSanPhamModels loaiSanPhamModel = new LoaiSanPhamModels();
        

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // hàm lấy dữ liệu loại sản phẩm và trả về json
        public JsonResult GetJsonList()
        {
            // gọi hàm get all để lấy tất cả dữ liệu trong bảng loại sp
            List<LoaiSanPham> lsp = loaiSanPhamModel.getAll();
            return Json(lsp, JsonRequestBehavior.AllowGet);
        }
        [ChildActionOnly]
        public  ActionResult _Menu()
        {
            List<LoaiSanPham> lsp = loaiSanPhamModel.getAll();
            return PartialView("~/Views/Share/_Menu.cshtml");
        }
        
       

       
    }
}
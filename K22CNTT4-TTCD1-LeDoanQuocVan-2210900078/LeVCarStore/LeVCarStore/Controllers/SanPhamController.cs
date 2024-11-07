using LeVCarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeVCarStore.Controllers
{
    public class CartController : Controller
    {
        private LeVCarStoreContext db = new LeVCarStoreContext();

        // Thêm sản phẩm vào giỏ hàng
        public ActionResult AddToCart(int id)
        {
            var sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
                return HttpNotFound();

            var cart = Session["Cart"] as List<ChiTietDonHang> ?? new List<ChiTietDonHang>();
            var item = cart.FirstOrDefault(i => i.SanPhamID == id);

            if (item == null)
            {
                cart.Add(new ChiTietDonHang
                {
                    SanPhamID = id,
                    SoLuong = 1,
                    Gia = sanPham.Gia
                });
            }
            else
            {
                item.SoLuong++;
            }

            Session["Cart"] = cart;
            return RedirectToAction("Index");
        }

        // Hiển thị giỏ hàng
        public ActionResult Index()
        {
            var cart = Session["Cart"] as List<ChiTietDonHang> ?? new List<ChiTietDonHang>();
            return View(cart);
        }
    }

}
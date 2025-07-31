using CraftCourses.Models;
using Microsoft.AspNetCore.Mvc;

namespace CraftCourses.Controllers
{
    public class CartController : Controller
    {
        private static List<CartItem> CartItems = new List<CartItem>();

        // عرض السلة
        public IActionResult Index()
        {
            return View(CartItems);
        }

        // إضافة للسلة
        public IActionResult AddToCart(int id, string title, decimal price)
        {
            if (!CartItems.Any(c => c.CourseId == id))
            {
                CartItems.Add(new CartItem
                {
                    CourseId = id,
                    Title = title,
                    Price = price
                });
            }
            return RedirectToAction("Index");
        }

        // حذف من السلة
        public IActionResult RemoveFromCart(int id)
        {
            var item = CartItems.FirstOrDefault(c => c.CourseId == id);
            if (item != null)
            {
                CartItems.Remove(item);
            }
            return RedirectToAction("Index");
        }

        // صفحة إدخال البيانات
        public IActionResult Checkout()
        {
            if (!CartItems.Any())
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        // بعد تأكيد الحجز
        [HttpPost]
        public IActionResult ConfirmCheckout(string name, string email)
        {
            // من الممكن تخزين المعلومات هنا مستقبلاً

            // تنظيف السلة بعد الحجز
            CartItems.Clear();

            return View();
        }
    }
}

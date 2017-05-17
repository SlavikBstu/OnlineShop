using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using OnlineShop.Models;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        Domain.OnlineShopEntities context = new Domain.OnlineShopEntities();

        //private List<users> UserCollection = new List<users>();

        Hashing hash = new Hashing();

        public JsonResult
            GetUsers()
        {
            var us = context.users.Select(u => new
            {
                Name = u.Name,
                Surname = u.Surname,
                Birthday = u.Birthday,
                Sex = u.Sex,
                Email = u.Email,
                Password = u.Password,
                Phone = u.Phone,
                Address = u.Address,
                Avatar = u.Avatar,
                Register_date = u.Register_date
            });

            return Json(us, JsonRequestBehavior.AllowGet);
        }

        public JsonResult
             GetProducts()
        {
            var pr = context.products.Select(p => new
            {
                Title = p.Title,
                Category_id = p.Category_id,
                Amount = p.Amount,
                Price = p.Price,
                Picture = p.Picture,
                Add_Date = p.Add_date
            });
            return Json(pr, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Authorisation()
        {
            return View();
        }

        public ActionResult Registered()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult Registered(HttpPostedFileBase upload, Register reg)
        {
            users cl = new users();

            cl.Name = reg.Name;
            cl.Surname = reg.Surname;
            cl.Birthday = reg.Birthday;
            cl.Sex = reg.Sex;
            cl.Email = reg.Email;
            cl.Phone = reg.Phone;

            if (upload != null)
            {
                // получаем имя файла 
                string fileName = System.IO.Path.GetFileName(upload.FileName);
                // сохраняем файл в папку Files в проекте 
                upload.SaveAs(Server.MapPath("~/ImgAvatars/" + fileName));
                cl.Avatar = "~/ImgAvatars/" + fileName;
            }
            else
            {
                cl.Avatar = "~/ImgAvatars/default.png";
            }

            cl.Password = hash.GetHashString(reg.Password);
            cl.Register_date = DateTime.Now;
                

            if (ModelState.IsValid)
            {
                context.users.Add(cl);
                context.SaveChanges();
                return Redirect("Registered");
            }

            return Redirect("Address");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Authorization user)
        {
            var Id = from p in context.users where (p.Email == user.Email && p.Password == hash.GetHashString(user.Password)) select p.User_id;

            if (Id != null)
            {
                return Redirect("Profile");
            }

            else
                return View();
        }

        public ActionResult Forgot()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Forgot(string email)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Profile(int id)
        {

            ViewBag.users = context.users.Find(id);

            IEnumerable<Domain.products> product = context.products;
            ViewBag.products = product;

            return View();
            //return Json(context.users, JsonRequestBehavior.AllowGet);
        }

        /*[HttpPost]
        public ActionResult Profile()
        {

            return Json(context.users);
        }*/

        [HttpGet]
        public ActionResult Products()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Products(HttpPostedFileBase upload, Product pr)
        {
            products p = new products();

            p.Title = pr.Title;
            p.Category_id = pr.Category_id;
            p.Amount = pr.Amount;
            p.Price = pr.Price;
           
            if (upload != null)
            {
                // получаем имя файла 
                string fileName = System.IO.Path.GetFileName(upload.FileName);
                // сохраняем файл в папку Files в проекте 
                upload.SaveAs(Server.MapPath("~/ImgProduct/" + fileName));
                p.Picture = "~/ImgProduct/" + fileName;
            }

            p.Add_date = DateTime.Now;
            if (ModelState.IsValid)
            {
                context.products.Add(p);
                context.SaveChanges();
                return Redirect("Products");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            IEnumerable<products> products = context.products;
            ViewBag.products = products;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Product p)
        {
            return View();
        }

        [HttpGet]
        public ViewResult ProductsEdit(int id)
        {
            products temp = context.products.Find(id);
            ViewBag.products = temp;

            return View();
        }

        [HttpPost]
        public RedirectResult ProductsEdit(products product_edit)
        {
            products temp = context.products.Find(product_edit.Product_id);
            temp = product_edit;

            context.SaveChanges();

            return Redirect("/Home/Edit");
        }

        [HttpGet]
        public RedirectResult ProductsRemove(int id)
        {
            products temp = context.products.Find(id);
            context.products.Remove(temp);
            context.SaveChanges();
            return Redirect("/Home/Edit");
        }

        
        [HttpGet]
        public ActionResult Product()
        {
            IEnumerable<Domain.products> product = context.products;
            ViewBag.products = product;
            return View();
        }

    }
}
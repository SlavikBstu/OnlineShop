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
        Hashing hash = new Hashing();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Basket()
        {
            return View();
        }

        public ActionResult Contacts()
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
        public ActionResult Registered(Register reg)
        {
            users cl = new users();            

            cl.Name = reg.Name;
            cl.Surname = reg.Surname;
            cl.Birthday = reg.Birthday;
            cl.Sex = reg.Sex;
            cl.Email = reg.Email;
            cl.Phone = reg.Phone;
            cl.Password = hash.GetHashString(reg.Password);
            cl.Register_date = DateTime.Now;

            context.users.Add(cl);
            context.SaveChanges();
            return View();
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
                return View("Profile");
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

        public ActionResult Profile()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult Profile()
        {
            return View();
        }*/

        public ActionResult Products()
        {

            return View();
        }

        [HttpPost]
        public ViewResult Products(HttpPostedFileBase upload, Product pr)
        {
            

            products p = new products();

            p.Title = pr.Title;
            p.Category_id = pr.Category_id;
            p.Amount = pr.Amount;
            p.Price = pr.Price;
            p.Stock = pr.Stock;
            //p.Picture = "222";
         

            if (upload != null)
            {
                // получаем имя файла 
                string fileName = System.IO.Path.GetFileName(upload.FileName);
                // сохраняем файл в папку Files в проекте 
                upload.SaveAs(Server.MapPath("~/Img/" + fileName));
                p.Picture = "~/Img/" + fileName;
            }

            p.Add_date = DateTime.Now;

            context.products.Add(p);
            context.SaveChanges();
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


    }
}
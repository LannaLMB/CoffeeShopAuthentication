using CoffeeShopAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopAuthentication.Controllers
{
    // Authorized - Must Be Logged In To View a Page
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoffeeShopDBEntities CoffDB = new CoffeeShopDBEntities();


            List<Item> ItemList = CoffDB.Items.ToList();

            ViewBag.ItemList = ItemList;
            ViewBag.CoffeeNames = CoffDB.Items.Select(x => x.Name);
            ViewBag.Names = GetName();

            return View();
        }


        // Get Name of Coffee From DB
        public List<string> GetName()
        {
            // To return a list of all cities
            CoffeeShopDBEntities CoffDB = new CoffeeShopDBEntities();


            //Lambda Expression
            return CoffDB.Items.Select(x => x.Name).Distinct().ToList();

        }


        // About Page
        public ActionResult About()
        {
            ViewBag.Message = "This Application Does Some Stuff";

            return View();
        }



        // Contact Page
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me!";

            return View();
        }


        // User Registration
        public ActionResult UserReg()
        {

            return View();
        }



        //List Coffee Products
        public ActionResult CoffeeProducts()
        {
            CoffeeShopDBEntities CoffDB = new CoffeeShopDBEntities();


            List<Item> ItemList = CoffDB.Items.ToList();

            ViewBag.ItemList = ItemList;
            ViewBag.CoffeeNames = CoffDB.Items.Select(x => x.Name);
            ViewBag.Names = GetName();

            return View();
        }



        // New User Info
        public ActionResult AddUser(UserInfo NewUser)
        {
            // validation
            // to add data from the model to the db


            // Pass the NewUser model to the AddUser view
            return View(NewUser);
        }
    }
}
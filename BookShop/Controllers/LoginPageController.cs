using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.Models;
using System.Data;


namespace BookShop.Controllers
{
    public class LoginPageController : Controller
    {

        // GET: LoginPage
        BALBookShop bl=new BALBookShop();

        [HttpPost]
        public ActionResult Index(CBUserModel CB) //Paasing the parameter for login validation
        {

            {
                DataSet dt = new DataSet();
                dt = bl.BgetLogin(CB.UserName, CB.Password);
                if (dt.Tables.Count > 0)
                {
                    return View("DashBoard");
                }

                else
                    return View();

            }
        }
        [HttpGet]
        public ActionResult Index( )
        {
            return View();
        }
        [HttpGet]
        public ActionResult DashBoard()
        {
            return View();
        }
    }
}
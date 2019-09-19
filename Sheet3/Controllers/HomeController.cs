using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using System.Web;
using System.Web.Mvc;
using ContactBAL;
namespace Sheet3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            BAL db = new BAL();
            var contacts = db.GetContacts();
            return View(contacts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create (Contact c)
        {
            BAL db = new BAL();
            db.AddContact(c);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            BAL db = new BAL();
            var currentContact = db.RetrieveContact(id);

            return View(currentContact);
        }


        public ActionResult Delete(int id)
        {
            BAL db = new BAL();
            db.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit (int id)
        {
            BAL db = new BAL();
            var contact = db.RetrieveContact(id);

            return View(contact);
        }
        [HttpPost]
        public ActionResult Edit (Contact c)
        {
            BAL db = new BAL();
            db.updateContact(c);

            return RedirectToAction("Index");
        }
    }
}
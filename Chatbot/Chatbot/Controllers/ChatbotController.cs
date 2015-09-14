using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chatbot.Controllers
{
    public class ChatbotController : Controller
    {
        //ClientAuthorReference.ServiceAuthorClient obj = new ClientAuthorReference.ServiceAuthorClient();

        ServiceReference1.IService1 obj = new ServiceReference1.IService1();

        // GET: Chatbot
        public ActionResult Index()
        {
            return View();
        }

        // GET: Chatbot/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Chatbot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chatbot/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chatbot/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Chatbot/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chatbot/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Chatbot/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

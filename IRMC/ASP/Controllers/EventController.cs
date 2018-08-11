using Data;

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

using Service;
using ASP.Models;

namespace ASP.Controllers
{

    public class EventController : Controller
    {
        DateTime localDate = DateTime.Now;
        Model2 ctx = new Model2();
        public static _event eventt;
        // GET: Event
        public ActionResult Index()
        {
            var client = new RestClient("http://localhost:18080/IRMCJEE-web/IRMC/event/");
            var request = new RestRequest(Method.GET);

            request.AddHeader("Content-type", "application/json");


            IRestResponse<List<EventViewModel>> u = client.Execute<List<EventViewModel>>(request);

            return View(u.Data);
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            var client = new RestClient("http://localhost:18080/IRMCJEE-web/IRMC/event/eventt/" + id);
            var request = new RestRequest(Method.GET);

            request.AddHeader("Content-type", "application/json");


            IRestResponse<List<EventViewModel>> u = client.Execute<List<EventViewModel>>(request);


            return View(u.Data[0]);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View("Create");
        }


        // POST: Event/Create
        [HttpPost]
        public ActionResult Create(_event ev)
        {

            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:18080/IRMCJEE-web/IRMC/event/");

            Client.PostAsJsonAsync<_event>("", ev).ContinueWith((postTask) => postTask.Result.IsSuccessStatusCode);
            return RedirectToAction("Index");
        }

        // GET: Event/Edit/5
        public ActionResult Edit(_event item)
        {
            {
                var u = ctx._event.Where(x => x.id_Ev == item.id_Ev).FirstOrDefault();

                if (ModelState.IsValid)
                {
                    u.title = item.title;
                    u.description = item.description;
                    u.capacity = item.capacity;
                    u.cat = item.cat;
                    u.startDate = item.startDate;
                    u.endDate = item.endDate;
                    u.startDate = localDate;



                    ctx.SaveChanges();

                    return RedirectToAction("Index");
                }
                else

                    return View(u);
            }
        }


        // POST: Event/Edit/5
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

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
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

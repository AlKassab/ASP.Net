using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;


namespace ASP.Controllers
{
    public class AnnoucementController : Controller
    {
        private List<Data.announcement> list = new List<Data.announcement>();
        // GET: Annoucement
        public ActionResult Index()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:18080/IRMCJEE-web/pi/");
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("annance").Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<Data.announcement>>().Result;
                foreach (var item in ViewBag.result)
                {
                    Data.announcement annance = new Data.announcement();
                    annance.name = item.name;
                    annance.description = item.description;
                    annance.id_An = item.id_An;
                    annance.category = item.category;
                    list.Add(annance);

                }
            }

            return View(list);
        }

        // GET: Annoucement/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Annoucement/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Annoucement/Create
        [HttpPost]
        public ActionResult Create(Data.announcement ann)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:18080/IRMCJEE-web/pi/");
                client.PostAsJsonAsync<Data.announcement>("annance", ann).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());

                // c bon ? behi a to nkamel
                /// ayh ab3a  mezelt sahethli message fi facebook keni faye9 taw njawbek mrogel 
                /// :* :*r ?


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Annoucement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Annoucement/Edit/5
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

        // GET: Annoucement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Annoucement/Delete/5
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

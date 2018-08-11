using ASP.Models;
using Data;
using Domaine.Entity;
using PusherServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class InstituteController : Controller
    {
      




        private List<InstituteViewModel> list = new List<InstituteViewModel>() ;
        // GET: Institute
        public ActionResult Index()

        {
            string markers = "[";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080/IRMCJEE-web/IRMC/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpResponseMessage = client.GetAsync("institute").Result;
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                ViewBag.result = httpResponseMessage.Content.ReadAsAsync<IEnumerable<InstituteViewModel>>().Result;
                foreach (var item in ViewBag.result)
                {
                    InstituteViewModel instViewModel = new InstituteViewModel();
                    instViewModel.name = item.name;
                    instViewModel.sigle = item.sigle;
                    instViewModel.id_inst = item.id_inst;
                    instViewModel.description = item.description;
                    instViewModel.type = item.type;
                    instViewModel.type_acces = item.type_acces;
                    instViewModel.image = item.image;
                    list.Add(instViewModel);
                    markers += "{";
                    markers += string.Format("'title'      : '{0}',", item.name);
                    markers += string.Format("'lat'        : '{0}',", item.latitude);
                    markers += string.Format("'lng'        : '{0}',", item.longitude);
                    markers += string.Format("'description': '{0}',", item.description);
                    markers += "},";
                }

                markers += "];";
                ViewBag.Markers = markers;


            }
            else
            {
                ViewBag.result = "error";
            }
           
            ViewBag.Markers = markers;
            return View(list);

        }
          
       

        // GET: Institute/Details/5
        public ActionResult Details(int id)

        {

            string markers = "[";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080/IRMCJEE-web/IRMC/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpResponseMessage = client.GetAsync("institute").Result;
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                ViewBag.result = httpResponseMessage.Content.ReadAsAsync<IEnumerable<InstituteViewModel>>().Result;
                foreach (var item in ViewBag.result)
                {  
                    InstituteViewModel instViewModel = new InstituteViewModel();
                    if (item.id_inst == id) {
                    instViewModel.name = item.name;
                    instViewModel.sigle = item.sigle;
                    instViewModel.id_inst = item.id_inst;
                    instViewModel.description = item.description;
                    instViewModel.type = item.type;
                    instViewModel.type_acces = item.type_acces;
                    instViewModel.image = item.image;
                    instViewModel.website = item.website;
                    instViewModel.mail = item.mail;
                    instViewModel.address = item.address;
                    instViewModel.code_postale = item.code_postale;


                        list.Add(instViewModel);
                        markers += "{";
                        markers += string.Format("'title'      : '{0}',", item.name);
                        markers += string.Format("'lat'        : '{0}',", item.latitude);
                        markers += string.Format("'lng'        : '{0}',", item.longitude);
                        markers += string.Format("'description': '{0}',", item.description);
                        markers += "},";
                    }
                }

                markers += "];";
                ViewBag.Markers = markers;
            }
            
            

            else
            {
                ViewBag.result = "error";
            }
            ViewBag.Markers = markers;
            return View(list);
        }

        // GET: Institute/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Institute/Create
        [HttpPost]
        public ActionResult Create(InstituteViewModel i)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:18080/IRMCJEE-web/IRMC/");
                client.PostAsJsonAsync<InstituteViewModel>("institute", i).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Institute/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Institute/Edit/5
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

        // GET: Institute/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Institute/Delete/5
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

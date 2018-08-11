using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Annoucement
    {
        public int id_An { get; set; }

        public Categorieannoucement cat { get; set; }

        public DateTime? endDate { get; set; }



        public DateTime? startDate { get; set; }

        public int? user_id { get; set; }

       
        public string description { get; set; }

        public string name { get; set; }
    }
}
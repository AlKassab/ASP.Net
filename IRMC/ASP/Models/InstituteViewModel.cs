using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class InstituteViewModel
    {
      
        public int id_inst { get; set; }

     
        public string address { get; set; }

       
        public string description { get; set; }

        public float latitude { get; set; }

        public float longitude { get; set; }

       
        public string name { get; set; }

       
        public string type { get; set; }

       
        public string code_postale { get; set; }

      
        public string image { get; set; }

       
        public string mail { get; set; }

      
        public string sigle { get; set; }

       
        public string type_acces { get; set; }

   
        public string website { get; set; }
    }
}

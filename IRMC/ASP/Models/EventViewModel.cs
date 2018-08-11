using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entity;

namespace ASP.Models
{
    public class EventViewModel
    {
       public EventViewModel()
        { }

        [Key]
        public int id_Ev { get; set; }

        [Column(TypeName = "bit")]
        public bool? canceled { get; set; }

        public int? capacity { get; set; }


        public category cat { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime creationDate { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? endDate { get; set; }

        [Column(TypeName = "bit")]
        public bool? etat { get; set; }


        [DataType(DataType.ImageUrl), Display(Name = "Image")]
        public string image { get; set; }

        public int? nbPart { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? startDate { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [Column(TypeName = "bit")]
        public bool valide { get; set; }

        public int? user_id { get; set; }

    }
}
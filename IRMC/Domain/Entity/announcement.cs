namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Table("dbirmc.announcement")]
    public  class announcement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public announcement()
        {
            application = new HashSet<application>();
        }

        [Key]
        public int id_An { get; set; }

        public categoryannouncement cat { get; set; }

        public DateTime? endDate { get; set; }



        public DateTime? startDate { get; set; }

        public int? user_id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? category_id_CatAn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<application> application { get; set; }

        public virtual categoryannouncement categoryannouncement { get; set; }

        public virtual user user { get; set; }
    }
}

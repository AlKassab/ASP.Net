namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("dbirmc.categoryannouncement")]
    public  class categoryannouncement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categoryannouncement()
        {
            announcement = new HashSet<announcement>();
        }

        [Key]
        public int id_CatAn { get; set; }

        [StringLength(255)]
        public string catname { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<announcement> announcement { get; set; }
    }
}

namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("dbirmc.journal")]
    public  class journal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public journal()
        {
            article = new HashSet<article>();
        }

        [Key]
        public int id_Journal { get; set; }

        public DateTime? date { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string filePath { get; set; }

        public int number { get; set; }

        public int? collection_id_Col { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<article> article { get; set; }

        public virtual collection collection { get; set; }
    }
}

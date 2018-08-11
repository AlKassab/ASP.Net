namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("dbirmc.post")]
    public  class post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public post()
        {
            comment = new HashSet<comment>();
            rating = new HashSet<rating>();
        }

        [Key]
        public long idPost { get; set; }

        [StringLength(255)]
        public string content { get; set; }

        [Column(TypeName = "timestamp")]
      
        public DateTime datepub { get; set; }

        [Column("object")]
        [StringLength(255)]
        public string _object { get; set; }

        public int state { get; set; }

        public int? user_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rating> rating { get; set; }

        public virtual user user { get; set; }
    }
}

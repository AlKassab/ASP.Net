namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("dbirmc.user")]
    public  class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            announcement = new HashSet<announcement>();
            application = new HashSet<application>();
            comment = new HashSet<comment>();
            _event = new HashSet<_event>();
            follow = new HashSet<follow>();
            follow1 = new HashSet<follow>();
            post = new HashSet<post>();
            rating = new HashSet<rating>();
            ticketevent = new HashSet<ticketevent>();
        }

        [Required]
        [StringLength(31)]
        public string role { get; set; }

        public int id { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string confirmPassword { get; set; }

        [StringLength(255)]
        public string country { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string firstName { get; set; }

        [StringLength(255)]
        public string gender { get; set; }

        [StringLength(255)]
        public string imagePath { get; set; }

        [StringLength(255)]
        public string lastName { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        public int phoneNumber { get; set; }

        [StringLength(255)]
        public string username { get; set; }

        [Column(TypeName = "bit")]
        public bool state { get; set; }

        public long time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<announcement> announcement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<application> application { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<_event> _event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<follow> follow { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<follow> follow1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<post> post { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rating> rating { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ticketevent> ticketevent { get; set; }
    }
}

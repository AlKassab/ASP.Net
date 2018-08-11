namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    [Table("dbirmc.institute")]
    public  class institute
    {
        [Key]
        public int id_inst { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public float latitude { get; set; }

        public float longitude { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        [StringLength(255)]
        public string code_postale { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        [StringLength(255)]
        public string mail { get; set; }

        [StringLength(255)]
        public string sigle { get; set; }

        [StringLength(255)]
        public string type_acces { get; set; }

        [StringLength(255)]
        public string website { get; set; }
    }
}

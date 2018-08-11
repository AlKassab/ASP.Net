namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("dbirmc.application")]
    public  class application
    {
        [Key]
        public int id_App { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public int? annoucement_id_An { get; set; }

        public int? user_id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string motivation { get; set; }

        public int number { get; set; }

        public virtual announcement announcement { get; set; }

        public virtual user user { get; set; }
    }
}

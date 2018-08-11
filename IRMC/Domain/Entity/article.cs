namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("dbirmc.article")]
    public  class article
    {
        public int id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int endPage { get; set; }

        public int startPage { get; set; }

        public int? journal_id_Journal { get; set; }

        public virtual journal journal { get; set; }
    }
}

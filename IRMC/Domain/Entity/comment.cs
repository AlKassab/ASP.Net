namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    [Table("dbirmc.comment")]
    public class comment
    {
        [Key]
        public long idCom { get; set; }

        [StringLength(255)]
        public string field { get; set; }

        [Column(TypeName = "timestamp")]
    
        public DateTime timestamp { get; set; }

        public long? post_idPost { get; set; }

        public int? user_id { get; set; }

        public virtual user user { get; set; }

        public virtual post post { get; set; }
    }
}

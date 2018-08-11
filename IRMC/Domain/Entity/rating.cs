namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    [Table("dbirmc.rating")]
    public  class rating
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idPost { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idsearcher { get; set; }

        public DateTime? daterating { get; set; }

        public int? value { get; set; }

        public virtual post post { get; set; }

        public virtual user user { get; set; }
    }
}

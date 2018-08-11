namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 
    [Table("dbirmc.ticketevent")]
    public  class ticketevent
    {
        [Key]
        public int id_Ticket { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public DateTime? orderDate { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public int? event_id_Ev { get; set; }

        public int? user_id { get; set; }

        public virtual _event _event { get; set; }

        public virtual user user { get; set; }
    }
}

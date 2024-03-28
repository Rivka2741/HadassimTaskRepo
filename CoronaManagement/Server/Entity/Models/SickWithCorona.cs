using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public partial class SickWithCoronaTbl
    {
        [Key]
        public int SickId { get; set; }
        public int? UserId { get; set; }
        public DateTime? PositiveResultDate { get; set; }
        public DateTime? RecoveryDate { get; set; }

        public virtual UserTbl? User { get; set; }
    }
}

//using ManagementOfCoronaPatients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Dto
{
    public partial class SickWithCoronaTblDto
    { 
        public int SickId { get; set; }

        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid house number.")]
        public int? UserId { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime? PositiveResultDate { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime? RecoveryDate { get; set; }
        //public virtual UserTbl? User { get; set; }
    }
}

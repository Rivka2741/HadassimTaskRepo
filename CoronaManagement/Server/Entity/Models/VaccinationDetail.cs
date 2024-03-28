using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public partial class VaccinationDetailTbl
    {
        [Key]
        public int VaccinationId { get; set; }
        public int? UserId { get; set; }
        public DateTime? VaccineDate { get; set; }
        public int? VaccineManufacturerId { get; set; }

        public virtual UserTbl? User { get; set; }
        public virtual VaccineManufacturerTbl? VaccineManufacturer { get; set; }
    }
}

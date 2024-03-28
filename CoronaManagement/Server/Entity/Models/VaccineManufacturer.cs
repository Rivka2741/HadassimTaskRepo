using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public partial class VaccineManufacturerTbl
    {
        public VaccineManufacturerTbl()
        {
            VaccinationDetails = new HashSet<VaccinationDetailTbl>();
        }
        [Key]
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; } = null!;

        public virtual ICollection<VaccinationDetailTbl> VaccinationDetails { get; set; }
    }
}

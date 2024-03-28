using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public partial class VaccineManufacturerTblDto
    {
        public int ManufacturerId { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name must contain only letters.")]
        public string ManufacturerName { get; set; } = null!;
    }
}

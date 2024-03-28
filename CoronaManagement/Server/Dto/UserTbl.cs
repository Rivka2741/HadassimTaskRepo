using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dto
{
    public partial class UserTblDto
    {
        public int UserId { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name must contain only letters.")]
        public string? FirstName { get; set; } = null!;

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name must contain only letters.")]
        public string? LastName { get; set; } = null!;

        [Required, MaxLength(9), MinLength(8)]
        public string? IdentityCard { get; set; } = null!;

        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please enter a valid city name.")]
        public string? City { get; set; } = null!;

        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please enter a valid street.")]
        public string? Street { get; set; } = null!;

        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid house number.")]
        public string? Number { get; set; } = null!;

        [Required, DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Phone]
        public string? Phone { get; set; } = null!;

        [Phone]
        public string? CellPhone { get; set; } = null!;
        public byte[]? Photo { get; set; }
    }
}

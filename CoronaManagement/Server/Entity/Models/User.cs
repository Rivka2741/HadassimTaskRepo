using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public partial class UserTbl
    {
        public UserTbl()
        {
            SickWithCoronas = new HashSet<SickWithCoronaTbl>();
            VaccinationDetails = new HashSet<VaccinationDetailTbl>();
        }
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string IdentityCard { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string Number { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; } = null!;
        public string CellPhone { get; set; } = null!;
        public byte[]? Photo { get; set; }

        public virtual ICollection<SickWithCoronaTbl> SickWithCoronas { get; set; }
        public virtual ICollection<VaccinationDetailTbl> VaccinationDetails { get; set; }
    }
}

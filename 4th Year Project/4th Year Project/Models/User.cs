using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4th_Year_Project.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        //Fíor no Breagach gealta le an Nuacht Litir.
        public bool GealtaLeAnNuachtLitir { get; set; }
        //Cén Saghas BailRíocht a bhfuil acu
        public  UserType UserType { get; set; }
        [Display(Name = "User Type")]
        public int UserTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Minimum18YearsOfAge]
        public DateTime? BirthDate { get; set; }
    }
}
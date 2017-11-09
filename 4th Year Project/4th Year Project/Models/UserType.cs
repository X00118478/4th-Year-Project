using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace _4th_Year_Project.Models
{
    public class UserType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //Cén costas a bhfuil i gceist le siniú suas 
        public double CostasSiniúSuas { get; set; }
        //Cé chomh fhada a raibh tú mar bailríocht
        public int  BailriochtIMhí { get; set; }
        //Aon Laiscaine a fuiar tú?
        public int Lascaine { get; set; }
        //An íocann tú gach mhí ?
        public static readonly int ÍocMarAThuiller = 1;

        public static readonly int measca = 0;

    }
}
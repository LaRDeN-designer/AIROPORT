using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_AIROPORT.Models
{
    public class Crews
    {
        [Display(Name = "Код экипажа")]
        public long ID { get; set; }

        [Display(Name = "Налетанно часов")]
        public string HourceFlown { get; set; }


        [Display(Name = "Код сотрудника 1")]
        public long? CodeStaf1ID { get; set; }
        [Display(Name = "Сотрудник 1")]
        public DbSet<Staffs> Staff1 { get; set; }

        [Display(Name = "код сотрудника 2")]
        public long? CodeStaf2ID { get; set; }
        [Display(Name = "Сотрудник 2")]
        public DbSet<Staffs> Staff2 { get; set; }

        [Display(Name = "Код сотрудника 3")]
        public long? CodeStaf3ID { get; set; }
        [Display(Name = "Сотрудник 3")]
        public DbSet<Staffs> Staff3 { get; set; }
    }
}

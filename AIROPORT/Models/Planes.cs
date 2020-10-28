using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_AIROPORT.Models
{
    public class Planes
    {
        [Display(Name = "Код самолета")]
        public long ID { get; set; }

        [Display(Name = "марка")]
        public string PlaneMark { get; set; }

        [Display(Name = "Вместимость")]
        public int CapacityPassengers { get; set; }

        [Display(Name = "Грузоподъемность")]
        public int Tonnage { get; set; }


        [Display(Name = "код типа самолета")]
        public long? TypePlane_ID { get; set; }
        [Display(Name = "Тип самолета")]
        public DbSet<TypePlanes> TypePlane { get; set; }


        [Display(Name = "Технические характеристики")]
        public string TechnicalParameters { get; set; }

        [Display(Name = "Дата выпуска")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Налетанно часов")]
        public int HourceFlown { get; set; }

        [Display(Name = "Дата последнего ремонта")]
        public DateTime DatelastRepair { get; set; }


        [Display(Name = "Код сотрудника")]
        public long? Staff_ID { get; set; }
        [Display(Name = "Сотрудник")]
        public DbSet<Staffs> Staff {get; set;}
    }
}

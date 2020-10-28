using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_AIROPORT.Models
{
    public class Tickets
    {
        [Display(Name = "ID пасажира")]
        public long ID { get; set; }

        [Display(Name = "ФИО пассажира")]
        public string NamePassenger { get; set; }

        [Display(Name = "Паспортные данные")]
        public string PassportDataPassengers { get; set; }

        [Display(Name = "Место")]
        public string Airoport { get; set; }


        [Display(Name = "Код рейса")]
        public long? Route_ID { get; set; }
        [Display(Name = "Рейс")]
        public DbSet<Routes> Route { get; set; }


        [Display(Name = "цена")]
        public int CostTiket { get; set; }
    }
}

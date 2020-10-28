using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_AIROPORT.Models
{
    public class Routes
    {
        [Display(Name = "Код рейса")]
        public long ID { get; set; }

        [Display(Name = "дата рейса")]
        public DateTime FlightDate { get; set; }

        [Display(Name = "Время отлета")]
        public DateTime TimeDeparture { get; set; }

        [Display(Name = "Откуда")]
        public string Departure { get; set; }

        [Display(Name = "Куда")]
        public string Arrival { get; set; }


        [Display(Name = "код экипажа")]
        public long? Crew_ID { get; set; }
        [Display(Name = "Экипаж")]
        public DbSet<Crews> Crew { get; set; }

        [Display(Name = "код самолета")]
        public long? Plane_ID { get; set; }
        [Display(Name = "Номер самолета")]
        public DbSet<Planes> Plane { get; set; }


        [Display(Name = "время полета")]
        public int FlightTime { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_AIROPORT.Models
{
    public class Staffs
    {
        [Display(Name = "Код сотрудника")]
        public long ID { get; set; }

        [Display(Name = "ФИО")]
        public string NameStaff { get; set; }

        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Паспортные данные")]
        public string PassportData { get; set; }


        [Display(Name = "Код должности")]
        public long? position_ID { get; set; }
        [Display(Name ="Доложность")]
        public DbSet<Positions> position { get; set; }
    }
}

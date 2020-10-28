using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_AIROPORT.Models
{
    public class Positions
    {
        [Display(Name = "Код должности")]
        public long ID { get; set; }

        [Display(Name = "Наименование")]
        public string NamePosition { get; set; }

        [Display(Name = "Оклад")]
        public int Salary { get; set; }

        [Display(Name = "Обязанности")]
        public string Duties { get; set; }

        [Display(Name = "Требования")]
        public string Requirements  { get; set; }
    }
}

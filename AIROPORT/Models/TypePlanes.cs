using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_AIROPORT.Models
{
    public class TypePlanes
    {
        [Display(Name = "Код типа")]
        public long ID { get; set; }

        [Display(Name = "Наименование")]
        public string NamePlane { get; set; }

        [Display(Name = "Назначение")]
        public string DestinationPlane { get; set; }

        [Display(Name = "Ограничения")]
        public string limitationsPlane { get; set; }
    }
}

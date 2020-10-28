using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AIROPORT.Data;
using BD_AIROPORT.Models;

namespace AIROPORT.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly AIROPORT.Data.AIROPORTContext _context;

        public IndexModel(AIROPORT.Data.AIROPORTContext context)
        {
            _context = context;
        }

        public IList<BD_AIROPORT.Models.Staffs> Staffs { get; set; }
        public IList<BD_AIROPORT.Models.Positions> Positions { get; set; }

        public async Task OnGetAsync()
        {
            Staffs = await _context.Staffs.ToListAsync();
            Positions = await _context.Positions.ToListAsync();
        }
    }
}

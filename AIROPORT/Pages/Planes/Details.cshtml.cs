using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AIROPORT.Data;
using BD_AIROPORT.Models;

namespace AIROPORT.Pages.Planes
{
    public class DetailsModel : PageModel
    {
        private readonly AIROPORT.Data.AIROPORTContext _context;

        public DetailsModel(AIROPORT.Data.AIROPORTContext context)
        {
            _context = context;
        }

        public BD_AIROPORT.Models.Planes Planes { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Planes = await _context.Planes.FirstOrDefaultAsync(m => m.ID == id);

            if (Planes == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

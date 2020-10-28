using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AIROPORT.Data;
using BD_AIROPORT.Models;

namespace AIROPORT.Pages.TypePlanes
{
    public class DetailsModel : PageModel
    {
        private readonly AIROPORT.Data.AIROPORTContext _context;

        public DetailsModel(AIROPORT.Data.AIROPORTContext context)
        {
            _context = context;
        }

        public BD_AIROPORT.Models.TypePlanes TypePlanes { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypePlanes = await _context.TypePlanes.FirstOrDefaultAsync(m => m.ID == id);

            if (TypePlanes == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

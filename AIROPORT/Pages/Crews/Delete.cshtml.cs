using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AIROPORT.Data;
using BD_AIROPORT.Models;

namespace AIROPORT.Pages.Crews
{
    public class DeleteModel : PageModel
    {
        private readonly AIROPORT.Data.AIROPORTContext _context;

        public DeleteModel(AIROPORT.Data.AIROPORTContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BD_AIROPORT.Models.Crews Crews { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Crews = await _context.Crew.FirstOrDefaultAsync(m => m.ID == id);

            if (Crews == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Crews = await _context.Crew.FindAsync(id);

            if (Crews != null)
            {
                _context.Crew.Remove(Crews);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

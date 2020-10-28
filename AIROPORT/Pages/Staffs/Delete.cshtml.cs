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
    public class DeleteModel : PageModel
    {
        private readonly AIROPORT.Data.AIROPORTContext _context;

        public DeleteModel(AIROPORT.Data.AIROPORTContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BD_AIROPORT.Models.Staffs Staffs { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Staffs = await _context.Staffs.FirstOrDefaultAsync(m => m.ID == id);

            if (Staffs == null)
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

            Staffs = await _context.Staffs.FindAsync(id);

            if (Staffs != null)
            {
                _context.Staffs.Remove(Staffs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

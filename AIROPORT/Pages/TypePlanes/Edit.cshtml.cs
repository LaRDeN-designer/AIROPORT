using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AIROPORT.Data;
using BD_AIROPORT.Models;

namespace AIROPORT.Pages.TypePlanes
{
    public class EditModel : PageModel
    {
        private readonly AIROPORT.Data.AIROPORTContext _context;

        public EditModel(AIROPORT.Data.AIROPORTContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TypePlanes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypePlanesExists(TypePlanes.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TypePlanesExists(long id)
        {
            return _context.TypePlanes.Any(e => e.ID == id);
        }
    }
}

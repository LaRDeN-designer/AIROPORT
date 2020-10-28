using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AIROPORT.Data;
using BD_AIROPORT.Models;

namespace AIROPORT.Pages.Crews
{
    public class CreateModel : PageModel
    {
        private readonly AIROPORT.Data.AIROPORTContext _context;

        public CreateModel(AIROPORT.Data.AIROPORTContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BD_AIROPORT.Models.Crews Crews { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Crew.Add(Crews);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AIROPORT.Data;
using BD_AIROPORT.Models;

namespace AIROPORT.Pages.Routes
{
    public class DetailsModel : PageModel
    {
        private readonly AIROPORT.Data.AIROPORTContext _context;

        public DetailsModel(AIROPORT.Data.AIROPORTContext context)
        {
            _context = context;
        }

        public BD_AIROPORT.Models.Routes Routes { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Routes = await _context.Routes.FirstOrDefaultAsync(m => m.ID == id);

            if (Routes == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

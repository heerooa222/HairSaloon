using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HairSaloon.Business;
using HairSaloon.Data;

namespace HairSaloon.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly HairSaloon.Data.ClientContext _context;

        public DetailsModel(HairSaloon.Data.ClientContext context)
        {
            _context = context;
        }

        public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Clients.FirstOrDefaultAsync(m => m.ID == id);

            if (Client == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

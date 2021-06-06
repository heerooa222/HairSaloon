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
    public class IndexModel : PageModel
    {
        private readonly HairSaloon.Data.ClientContext _context;

        public IndexModel(HairSaloon.Data.ClientContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; }

        public async Task OnGetAsync()
        {
            Client = await _context.Clients.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreMVC.Pages
{
    public class InstallationsModel : PageModel
    {
        private readonly ubuntudbContext _context;

        public InstallationsModel(ubuntudbContext context)
        {
            _context = context;
        }

        public IList<Installations> Installations { get; set; }

        public void OnGet()
        {
            Installations = _context.Installations.ToList();
        }
    }
}
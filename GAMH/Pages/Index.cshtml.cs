using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAMH.Helpers;
using GAMH.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GAMH.Pages
{
    public class IndexModel : PageModel
    {
        

        public void OnGet()
        {

        }

        [BindProperty]
        public ContactViewModel Contact { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            JsonBL jsonBl = new JsonBL();
            jsonBl.AddContactMessage(Contact);

            return Redirect("/ReceivingDetails");
        }
    }
}

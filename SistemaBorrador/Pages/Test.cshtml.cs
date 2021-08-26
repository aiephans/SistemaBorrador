using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SistemaBorrador.Pages
{
    public class TestModel : PageModel
    {
        public ActionResult OnGet()
        {
            string sessionId = Request.Cookies["sessionId"];

            if (string.IsNullOrEmpty(sessionId) || !sessionId.Equals(HttpContext.Session.GetString("sessionId")))
            {
                return RedirectToPage("./index");
            }

            return Page();

        }
    }
}

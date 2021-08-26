using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBorrador.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

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

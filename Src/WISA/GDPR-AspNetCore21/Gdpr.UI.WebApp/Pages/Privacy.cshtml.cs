﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Gdpr.UI.WebApp.Pages.Shared;

namespace Gdpr.UI.WebApp.Pages
{
    public class PrivacyModel : BasePageModel
    {
        public IActionResult OnGet()
        {
            SetPageStatusMsg("Information about our privacy policy", ExistingMsg.Overwrite);

            return Page();
        }
    }
}
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace TeamRedBlazor.Client.Server.Pages
{
    public class LoginIDPModel : PageModel
    {
        public async Task OnGetAsync()
        {
      
            if (!HttpContext.User.Identity.IsAuthenticated)
            {

                await HttpContext.ChallengeAsync(OpenIdConnectDefaults.AuthenticationScheme);
            }
            else
            {
                // redirect to the root
                Response.Redirect(Url.Content("~/").ToString());
            }
        }
    }
}
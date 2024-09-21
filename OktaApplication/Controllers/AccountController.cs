using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Okta.AspNetCore;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;


namespace OktaApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return Challenge(new AuthenticationProperties { RedirectUri = Url.Action("Index", "Home") }, OpenIdConnectDefaults.AuthenticationScheme);
        }

        public IActionResult Logout()
        {

            return SignOut(new AuthenticationProperties { RedirectUri = Url.Action("Index", "Home") }, OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}

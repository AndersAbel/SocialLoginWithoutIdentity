using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Google;

namespace SocialLoginWithoutIdentity
{
    public partial class Startup
    {
        private void ConfigureAuth(IAppBuilder app)
        {
            const string authenticationType = "ApplicationCookie";

            app.UseCookieAuthentication(new CookieAuthenticationOptions
                {
                    AuthenticationType = authenticationType,
                    LoginPath = new PathString("/Account/Login")
                });

            app.SetDefaultSignInAsAuthenticationType(authenticationType);

            app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions
                {
                    ClientId = GoogleClientId,
                    ClientSecret = GoogleClientSecret
                });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasutihalozatok.Auth;

namespace Vasutihalozatok.Controller
{
    class RaliwayPackerController
    {
        private IAuthenticator authenticator = UserAuthenticator.Instance;

        public void SubscibeToLogout(IAuthenticator.LogoutDelegate logoutDelegate)
        {
            authenticator.LogoutEvent += logoutDelegate;
        }

        public void UnsubscribeFromLogout(IAuthenticator.LogoutDelegate logoutDelegate)
        {
            authenticator.LogoutEvent -= logoutDelegate;
        }

        public void Logout()
        {
            authenticator.Logout();
        }



    }
}

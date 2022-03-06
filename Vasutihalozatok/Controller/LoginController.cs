using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasutihalozatok.Auth;
using Vasutihalozatok.Entity;

namespace Vasutihalozatok.Controller
{
    class LoginController
    {
        private IAuthenticator authenticator = UserAuthenticator.Instance;
        public Person HandleLoginAttempt(string username, string password)
        {
            return authenticator.Aute(username, password);
        }
    }
}

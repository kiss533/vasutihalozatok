using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasutihalozatok.Entity;

namespace Vasutihalozatok.Auth
{
    public interface IAuthenticator
    {

        public delegate void LogoutDelegate();

        public event LogoutDelegate LogoutEvent;

        

        public Person Aute(string username , string password);

        public void Logout();
    }
}

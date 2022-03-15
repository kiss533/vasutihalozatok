using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasutihalozatok.Entity;
using Vasutihalozatok.Execptions;

namespace Vasutihalozatok.Auth
{
    public sealed class UserAuthenticator : IAuthenticator
    {
        public event IAuthenticator.LogoutDelegate LogoutEvent;


        private static Datatextcontent data = Datatextcontent.Instance;

        public Person? LogginPerson { get; set; }


        private static UserAuthenticator? userAuthenticator;

        public static UserAuthenticator Instance
        {

            get
            {
                if (userAuthenticator == null)
                {
                    userAuthenticator = new UserAuthenticator();
                }
                return userAuthenticator;
            }

    }
        
        public Person Aute(string username, string password)
        {
            
            Person? user = data.Felhasznalok.FirstOrDefault(user => user.felhasznalonev == username);
            if (user == null)
            {
                throw new VasutExecption();
            }
            if (!BCrypt.Net.BCrypt.Verify(password, user.jelszo))
            {
                throw new VasutExecption();
            }
            LogginPerson = user;
            return user;
           
        }
    
        public void Logout()
        {
            LogginPerson = null;
            LogoutEvent?.Invoke();
        }
    
    
    }
}

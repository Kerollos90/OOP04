using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.@interface
{
    public interface IAuthenticationService
    {
        public bool AuthenticateUser(string UserName, int Password);

        public bool AuthorizeUser(string UserName, string Roles);



    }


    public class BasicAuthenticationService() : IAuthenticationService
    {


        string username = "kerollos";
        int password = 45;
        string roles = "admin";

        bool x;
        public bool AuthenticateUser(string UserName, int Password)
        {
            if (UserName != null && Password != null)
            {
                if (UserName == username && Password == password)
                {
                    return x = true;
                }
                else
                { return x = false; }

            }
            else { return x = false; }
        }



        public bool AuthorizeUser(string UserName, string Roles)
        {
            if (UserName == username && Roles == roles)
            {
                return x = true;
            }
            else
            { return x = false; }



        }




    }




}

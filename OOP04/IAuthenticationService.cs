using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string UserName, int Password ,out bool x);
     
      public  void AuthorizeUser(string UserName, int Password);



    }


    public class BasicAuthenticationService() : IAuthenticationService, IComparer
    {


        string username = "user";
        int password = 45;
       

        bool AuthenticateUser(string UserName, int Password, out bool x)
        {
            if (username != null)
            {
                if (UserName == username)
                {
                    return x= true;
                }
                else 
                { return x = false; }    
            }
                return false;
        }

    

        public void AuthorizeUser(string UserName, int Password)
        {
            
        }

        public int Compare(object? x, object? y)
        {
              
            
        }

      
    }




}

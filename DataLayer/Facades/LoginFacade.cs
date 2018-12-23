using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public static class LoginFacade
    {
        private static DataModel entity = new DataModel();
        public static DataModel Entity { get => entity; }

        public static int Login(string token_Id)
        {
            try
            {
                
            }
            catch(Exception ex)
            {

            }
        }

        public static int Login(string uname, string password)
        {

        }
    }
}

using Practic2.Interfaces;
using Practic2.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2.Logic
{
    public class Auth : IAuth
    {
        ShopDBEntities dbContext=new ShopDBEntities();
        public bool Check(string login, string password)
        {
            return dbContext.Users.FirstOrDefault(u=>u.Login==login&&u.Pass==password) != null;
        }
    }
}

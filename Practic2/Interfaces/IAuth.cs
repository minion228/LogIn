using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2.Interfaces
{
    public interface IAuth
    {
        bool Check(string login, string password);
    }
}

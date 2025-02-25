using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2.Interfaces
{
    public interface IProduct
    {
        string Name { get; }
        string Description { get; }
        decimal Price { get; }
    }
}

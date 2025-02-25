using Practic2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2.Logic
{
    public class Product:IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"Товар:{Name} по цене: {Price} рублей";
        }
    }
    
}

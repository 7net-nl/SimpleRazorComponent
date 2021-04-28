using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomRazor.Models
{
    public class SaveProduct
    {
        public string Save(string Product ="")
        {
            return $"Save : {Product}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomRazor.Models
{
    public class InputViewModel
    {
        public InputViewModel()
        {
            User1 = "";
            User2 = "";
            UserText1 = "";
            UserText2 = "";
        }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string UserText1 { get; set; }
        public string UserText2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headless.DB.DataObj
{
    public class Input
    {
        public string InputName { get; set; }
        
    }

    public enum InputType 
    {
        text = 0,
        tel = 1,
        email = 2,
        checkbox = 3,
        file = 4,
        image = 5,
        password = 6,
        date = 7,
        time = 8,
        color = 9,
    }
}

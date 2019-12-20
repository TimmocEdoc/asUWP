using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Interfaces
{
    interface ISong
    {
        String Name { get; set; }
        String Author { get; set; }
        String Singer { get; set; }
        String Thumbnail { get; set; }
        String Link { get; set; }
    }
}

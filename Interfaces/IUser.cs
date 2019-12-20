using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Interfaces
{
    interface IUser
    {
        String Firstname { set; get; }
        String Lastname { set; get; }
        String Password { set; get; }
        String Email { set; get; }
        String Address { set; get; }
        String Avatar { set; get; }
        String Phone { set; get; }
        int Gender { set; get; }
        String Birthday { set; get; }

    }
}

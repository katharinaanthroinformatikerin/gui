using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public interface IState
    {
        bool Purchase();
        bool Install();
        bool Play();
        bool Uninstall();
        bool Refund();
        bool Download();
        bool Update();
        bool Borrow();
        bool Lend();
        bool GetBack();

        string getName();
    }
}

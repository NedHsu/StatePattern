using StatePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Models.Contexts
{
    public class StateContext
    {
        IState State = null;
    }
}

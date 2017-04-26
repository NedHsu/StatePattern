using StatePattern.Interface;
using StatePattern.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Base
{
    public abstract class BaseState : IState
    {
        Enums.State value = 0;

        public BaseState(StateContext context)
        {

        }

        public abstract void Handle(int Value);


    }
}

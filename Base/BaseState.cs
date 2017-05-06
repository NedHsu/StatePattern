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
        protected Enums.State value = 0;

        protected StateContext _context = null;

        public BaseState(StateContext context)
        {
            _context = context;
        }

        public int GetValue()
        {
            return (int)this.value;
        }

        public abstract void Handle(int Value);


    }
}

using StatePattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Models.Contexts;

namespace StatePattern.Models.States
{
    public class StateB : BaseState
    {
        public StateB(StateContext context) : base(context)
        {
            base.value = Enum.State.StateB;
        }

        public override void Handle(int Value)
        {
            base._context.SetState(new StateC(base._context));
        }
    }
}

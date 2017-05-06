using StatePattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Models.Contexts;

namespace StatePattern.Models.States
{
    public class StateC : BaseState
    {
        public StateC(StateContext context) : base(context)
        {
            base.value = Enums.State.StateC;
        }

        public override void Handle(int Value)
        {
            base._context.SetState(new StateA(base._context));
        }
    }
}

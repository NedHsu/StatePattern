using StatePattern.Interface;
using StatePattern.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Models.Contexts
{
    public class StateContext
    {
        IState _State = null;

        public StateContext()
        {
            //Init State
            this.SetState(new StateA(this));
        }

        public StateContext(IState state) : this()
        {
            this.SetState(state);
        }

        public void SetState(IState state)
        {
            this._State = state;
        }

        public void Request(int value)
        {
            Console.WriteLine($"State: {this._State.GetValue()}, Input: {value}");
            this._State.Handle(value);
            Console.WriteLine($"To State: {this._State.GetValue()}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public enum MoveState {NotMoved, HasMoved}
    public interface ICommand
    {
        MoveState moveState { get; set; }
        void Execute();
    }
}

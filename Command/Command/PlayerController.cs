using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class PlayerController
    {
        public Queue<ICommand> Commands;
        public PlayerController() 
        {
            Commands = new Queue<ICommand>();
        }

        public void AddMove(ICommand command) 
        {
            Commands.Enqueue(command);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class MoveForwardFive:ICommand
    {
        public MoveState moveState { get; set; }

        private MoveForward movef;
        private Player player;
        public MoveForwardFive(Player Player)
        {
            this.player = Player;
            moveState = MoveState.NotMoved;

            movef = new MoveForward(Player);
        }
        public void Execute()
        {
            for (int i = 0; i < 5; i++)
            {
                movef.Execute();
            }
            moveState = MoveState.HasMoved;

            Console.WriteLine(player.ReturnLocation());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class MoveBackwardFive : ICommand
    {
        public MoveState moveState { get; set; }

        private MoveBackward moveb;
        private Player player;
        public MoveBackwardFive(Player Player)
        {
            this.player = Player;
            moveState = MoveState.NotMoved;

            moveb = new MoveBackward(Player);
        }
        public void Execute()
        {
            for (int i = 0; i < 5; i++)
            {
                moveb.Execute();
            }
            moveState = MoveState.HasMoved;

            Console.WriteLine(player.ReturnLocation());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class MoveDown:ICommand
    {
        public MoveState moveState { get; set; }

        private Player player;
        public MoveDown(Player Player)
        {
            this.player = Player;
            moveState = MoveState.NotMoved;
        }
        public void Execute()
        {
            this.player.LocationY--;
            moveState = MoveState.HasMoved;
            player.ReturnLocation();
            Console.WriteLine(player.ReturnLocation());
        }
    }
}

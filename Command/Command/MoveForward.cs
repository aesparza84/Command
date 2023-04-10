using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class MoveForward : ICommand
    {
        public MoveState moveState { get; set; }

        private Player player;
        public MoveForward(Player Player)
        {
            this.player = Player;
            moveState = MoveState.NotMoved;
        }
        public void Execute()
        {
            this.player.LocationX++;
            moveState = MoveState.HasMoved;
           
            Console.WriteLine(player.ReturnLocation());
        }
    }
}

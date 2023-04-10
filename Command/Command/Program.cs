
namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<ICommand> RedoCommandStack = new Stack<ICommand>();
            Console.WriteLine("Hello, World!\n");

            Player player = new Player();
            Console.WriteLine(player.ReturnLocation());


            PlayerController controller = new PlayerController();

            MoveForward moveforward = new MoveForward(player);
            MoveBackward movebackward = new MoveBackward(player);
            MoveUp moveup = new MoveUp(player);
            MoveDown movedown = new MoveDown(player);
            MoveBackwardFive movebackwardfive = new MoveBackwardFive(player);
            MoveForwardFive moveforwardfive = new MoveForwardFive(player);

            controller.AddMove(moveforward);
            controller.AddMove(moveforward);
            controller.AddMove(movebackward);
            controller.AddMove(moveup);
            controller.AddMove(moveup);
            controller.AddMove(movedown);
            controller.AddMove(moveforwardfive);

            controller.AddMove(moveup);


            foreach (ICommand item in controller.Commands)
            {
                item.Execute();
                RedoCommandStack.Push(item);
            }

            Console.WriteLine("Now Redo\n");
            Console.WriteLine(player.ReturnLocation());
            foreach (ICommand item in RedoCommandStack)
            {
                ICommand j;

                if (item.GetType() == typeof(MoveBackward))
                {
                    j = new MoveForward(player);
                    j.Execute();
                }
                if (item.GetType() == typeof(MoveForward))
                {
                    j = new MoveBackward(player);
                    j.Execute();
                }
                if (item.GetType() == typeof(MoveUp))
                {
                    j = new MoveDown(player);
                    j.Execute();
                }
                if (item.GetType() == typeof(MoveDown))
                {
                    j = new MoveUp(player);
                    j.Execute();
                }
                if (item.GetType() == typeof(MoveForwardFive))
                {
                    j = new MoveBackwardFive(player);
                    j.Execute();
                }
                if (item.GetType() == typeof(MoveBackwardFive))
                {
                    j = new MoveForwardFive(player);
                    j.Execute();
                }
            }
        }
    }
}
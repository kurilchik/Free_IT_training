using System;

namespace week_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Добро пожаловать в игру «КТО ХОЧЕТ СТАТЬ МИЛЛИОНЕРОМ?»!\n");            
            
            Game.Rules();          
                       
            User.UserNameInput();                      
                        
            Console.Clear();

            Game game = new Game();

            game.Start();
           
        }
    }
}

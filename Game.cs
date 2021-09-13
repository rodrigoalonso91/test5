using System;
using System.Threading.Tasks;

namespace test5
{
    public class Game
    {

        public static async Task StartGame()
        {
           await Task.Run(()=> Task.Delay(10000));
        }
    }
}

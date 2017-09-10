using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Program
{
    static void Main()
    {
        ConsoleGraphic camera=new ConsoleGraphic(10,10,19);
        Player me = new Player();
        while (true)
        {
            camera.Show();
            me.Move();
        }
    }
}
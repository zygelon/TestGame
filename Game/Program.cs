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
        ConsoleGraphic a=new ConsoleGraphic(10,10);
        Player al = new Player();
        while (true)
        {
            a.Show();
            al.MoveUp();
            Coordinate.DebugCoordinateObjects();
            Console.ReadKey();
        }
    }
}
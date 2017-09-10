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
        new Wall(3, 3);
        while (true)
        {
            camera.Show();
            Coordinate.DebugCoordinateObjects();
            me.Move();
        }
    }
}
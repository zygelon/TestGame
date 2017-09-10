using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Coordinate : ObjectsInformation
{
    public int x, y;
    public char Symbol { get;private set; }
    public Coordinate(int x,int y,char symbol) : base()
    {
        this.x = x;
        this.y = y;
        this.Symbol = symbol;
        Objects
    }
    public static void DebugCoordinateObjects()
    {
        Console.WriteLine("Count Objects=" + Length);
        Console.WriteLine("Coordinate Objects:");
        for(int i=0;i<Length;++i)
            Console.Write("X="+GetObject(i).x+" Y="+GetObject(i).y+" Symbol="+GetObject(i).Symbol+'\n');
        Console.WriteLine();
    }
}
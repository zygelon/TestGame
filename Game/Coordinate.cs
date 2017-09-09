using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Coordinate
{
    private static List<Coordinate> Objects = new List<Coordinate>();
    public static int Lenght
    {
        get{ return Objects.Count; }
    }
    public static Coordinate GetObject(int index)
    {
        return Objects[index];
    }

    public int x, y;
    public char Symbol { get;private set; }
    public Coordinate(int x,int y,char symbol)
    {
        this.x = x;
        this.y = y;
        this.Symbol = symbol;
        Objects.Add(this);
    }
    public static void DebugCoordinateObjects()
    {
        Console.WriteLine("Coordinate Objects:");
        for(int i=0;i<Lenght;++i)
            Console.Write("X="+GetObject(i).x+" Y="+GetObject(i).y+" Symbol="+GetObject(i).Symbol+'\n');
        Console.WriteLine();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ObjectsInformation
{
    private static List<Coordinate> Objects = new List<Coordinate>();

    protected static char FreePlaceSym { get; private set; }
    protected static char[,] inf;
    protected ObjectsInformation(int )
    static ObjectsInformation()
    {
        Rows = 10;
        Columns = 10;
        inf = new char[Rows,Columns];
        FreePlaceSym = '.';
    }

    public static int Rows { get; private set; }
    public static int Columns { get; private set; }

    public static int Length
    {
        get{ return Objects.Count; }
    }

    public static Coordinate GetObject(int index)
    {
        return Objects[index];
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConsoleGraphic
{
    char[,] inf;
    public static int Length { get; private set; }
    public static int Height { get; private set; }
    public static int Indent=18;
    char freePlaceSym;

    public ConsoleGraphic(int length,int height,int indent=20)
    {
        Indent = indent;
        freePlaceSym = '.';
        Length = length;
        Height = height;
        inf = new char[height, length];
    }
    
    public void Show()
    {
        CleanInf();
        SetCoordinatesToInf();
        OutputToDisplay();
    }

    private void OutputToDisplay()
    {
        for (int i = Height-1; i >= 0; --i)
        {
            for (int j = 0; j < Length; ++j)
                Console.Write(inf[i, j] + " ");
            Console.WriteLine();
        }
        MakeIndent();
    }
    private void SetCoordinatesToInf()//Заполняет массив inf игровыми объектами
    {
        for (int i = 0; i < Coordinate.Lenght; ++i)
            inf[Coordinate.GetObject(i).y, Coordinate.GetObject(i).x] = Coordinate.GetObject(i).Symbol;
    }
    private void MakeIndent()
    {
        for (int i = 0; i < Indent; ++i)
            Console.WriteLine();
    }

    private void CleanInf()
    {
        for (int i = 0; i < Height; ++i)
            for (int j = 0; j < Length; ++j)
                inf[i, j] = freePlaceSym;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConsoleGraphic
{
    char[,] inf;
    public int Length { get; private set; }
    public int Height { get; private set; }
    char freePlaceSym;

    public ConsoleGraphic(int length,int height)
    {
        freePlaceSym = '.';
        this.Length = length;
        this.Height = height;
        inf = new char[height, length];
    }
    
    public void Show()
    {
        SetCoordinatesToInf();
        SetFreePlaceToInf();
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
    }
    private void SetFreePlaceToInf()//Заполняет пустые места на массиве сиволом freePlaceSym
    {
        for (int i = 0; i < Height; ++i)
            for (int j = 0; j < Length; ++j)
                if (inf[i, j] == (char)0) inf[i, j] = freePlaceSym;
    }
    private void SetCoordinatesToInf()//Заполняет массив inf игровыми объектами
    {
        for (int i = 0; i < Coordinate.Lenght; ++i)
            inf[Coordinate.GetObject(i).y, Coordinate.GetObject(i).x] = Coordinate.GetObject(i).Symbol;
    }
}

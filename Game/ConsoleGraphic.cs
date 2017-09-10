using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConsoleGraphic : ObjectsInformation
{
    public static int Indent=18;

    public ConsoleGraphic(int length,int height,int indent=20) : base()
    {
        Indent = indent;
    }
    
    public void Show()
    {
        //SetCoordinatesToInf();
        //OutputToDisplay();
        Console.Write(Length + " " + ObjectsInformation.Length);
    }

    private void OutputToDisplay()
    {
        for (int i = Columns-1; i >= 0; --i)
        {
            for (int j = 0; j < Rows; ++j)
                if (inf[i, j] == 0) Console.Write(". ");
                else Console.Write(inf[i, j] + " ");
            Console.WriteLine();
        }
        MakeIndent();
    }
    private void SetCoordinatesToInf()//Заполняет массив inf игровыми объектами
    {
        for (int i = 0; i < Rows; ++i)
            inf[GetObject(i).y, GetObject(i).x] = GetObject(i).Symbol;
    }
    private void MakeIndent()
    {
        for (int i = 0; i < Indent; ++i)
            Console.WriteLine();
    }

}

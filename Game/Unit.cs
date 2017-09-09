using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Unit
{
    int hp;
    Coordinate position;
    protected Unit(Coordinate pos,int hp)
    {
        position = pos;
        this.hp = hp;
    }

    public virtual void MoveUp()
    {
        if (position.y+1 < ConsoleGraphic.Height) ++position.y;
    }
    public virtual void MoveDown()
    {
        if (position.y - 1 >= 0) --position.y;
    }
    public virtual void MoveRight()
    {
        if (position.x + 1 < ConsoleGraphic.Length) ++position.x;
    }
    public virtual void MoveLeft()
    {
        if (position.x - 1 >= 0) --position.x;
    }
}
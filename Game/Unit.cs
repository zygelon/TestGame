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
        position = new Coordinate(pos.x, pos.y, pos.Symbol);
        this.hp = hp;
    }

    public virtual void MoveUp()
    {
        if (position.y < ConsoleGraphic.Height) ++position.y;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Unit : BaseObject
{
    int hp;
    protected Unit(Coordinate pos, int hp) : base(pos) { this.hp = hp; }

    public virtual void MoveUp()
    {
        if (position.y+1 < ConsoleGraphic.Columns) ++position.y;
    }
    public virtual void MoveDown()
    {
        if (position.y - 1 >= 0) --position.y;
    }
    public virtual void MoveRight()
    {
        if (position.x + 1 < ConsoleGraphic.Rows) ++position.x;
    }
    public virtual void MoveLeft()
    {
        if (position.x - 1 >= 0) --position.x;
    }
}
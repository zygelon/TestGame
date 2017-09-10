using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Wall : BaseObject
{
    private const char _symbol_ = '#';
    public Wall(int x,int y) : base(new Coordinate(x,y,_symbol_)) { }
}

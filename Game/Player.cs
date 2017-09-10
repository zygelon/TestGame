using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player : Unit
{
    const char _playerSymbol_='X';
    const int _PlayerHP_ = 10;
    const int _startPosX_ = 2, _startPos_Y = 1;

    public Player(int x,int y) : base(new Coordinate(x, y, _playerSymbol_), _PlayerHP_) { }
    public Player() : base(new Coordinate(_startPosX_, _startPos_Y, _playerSymbol_),_PlayerHP_) { }

    public void Move()
    {
        switch(Console.ReadKey(true).Key)
        {
            case ConsoleKey.W:
                MoveUp();
                break;
            case ConsoleKey.UpArrow:
                MoveUp();
                break;

            case ConsoleKey.S:
                MoveDown();
                break;
            case ConsoleKey.DownArrow:
                MoveDown();
                break;

            case ConsoleKey.D:
                MoveRight();
                break;
            case ConsoleKey.RightArrow:
                MoveRight();
                break;

            case ConsoleKey.A:
                MoveLeft();
                break;
            case ConsoleKey.LeftArrow:
                MoveLeft();
                break;
        }
    }
}

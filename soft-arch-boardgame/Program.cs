using System;

namespace soft_arch_boardgame
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeDBoard board = new ThreeDBoard(4, 4, 4);
            // The board has two- and three-dimensional versions
            // available because of inheritance. This is confusing
            // for the programmers trying to use the ThreeDBoard.
            // Which version of GetTile should you call?
            board.GetTile(1, 3);
            board.GetTile(1, 3, 2);
        }
    }
}
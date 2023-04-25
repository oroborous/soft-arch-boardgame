using System.Collections.Generic;

namespace soft_arch_boardgame
{
    public class Board
    {
        public int Width { get; }
        public int Height { get; }
        
        private Tile[,] tiles;

        public Board(int width, int height)
        {
            Width = width;
            Height = height;
            tiles = new Tile[width, height];
            // init Tile objects in array
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    tiles[i, j] = new Tile();
                }
            }
        }

        /**
         * The before version of ThreeDBoard will inherit all these
         * methods from Board, but can it use any of them? What
         * would calling the two-dimensional GetTile method even
         * mean for a ThreeDBoard?
         */
        public Tile GetTile(int x, int y)
        {
            return tiles[x, y];
        }

        public void AddGamePiece(GamePiece gamePiece, int x, int y)
        {
            tiles[x, y].AddGamePiece(gamePiece);
        }

        public void RemoveGamePiece(GamePiece gamePiece, int x, int y)
        {
            tiles[x, y].RemoveGamePiece(gamePiece);
        }

        public void RemoveGamePieces(int x, int y)
        {
            tiles[x, y].RemoveGamePieces();
        }

        public List<GamePiece> GetGamePieces(int x, int y)
        {
            return tiles[x, y].GetGamePieces();
        }
    }
}
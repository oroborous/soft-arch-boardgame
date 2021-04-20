using System.Collections.Generic;

namespace soft_arch_boardgame.after
{
    public class ThreeDBoard
    {
        public int Width { get; }
        public int Height { get; }
        public int Zpos { get; }

        /**
         * By using composition instead of inheritance, the
         * ThreeDBoard becomes a collection of two-dimensional
         * boards.
         */
        private Board[] boards;

        public ThreeDBoard(int width, int height, int zpos)
        {
            Width = width;
            Height = height;
            Zpos = zpos;

            // Create Z number of boards with width X and height Y
            boards = new Board[zpos];
            for (int i = 0; i < zpos; i++)
            {
                boards[i] = new Board(width, height);
            }
        }

        /**
         * Requests involving tiles are delegated to the two-dimensional
         * board on the given z-layer
         */
        public Tile GetTile(int x, int y, int z)
        {
            return boards[z].GetTile(x, y);
        }

        public void AddGamePiece(GamePiece gamePiece, int x, int y, int z)
        {
            boards[z].AddGamePiece(gamePiece, x, y);
        }

        public void RemoveGamePiece(GamePiece gamePiece, int x, int y, int z)
        {
            boards[z].RemoveGamePiece(gamePiece, x, y);
        }

        public void RemoveGamePieces(int x, int y, int z)
        {
            boards[z].RemoveGamePieces(x, y);
        }

        public List<GamePiece> GetGamePieces(int x, int y, int z)
        {
            return boards[z].GetGamePieces(x, y);
        }
    }
}
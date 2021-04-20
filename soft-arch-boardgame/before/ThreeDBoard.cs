using System.Collections.Generic;

namespace soft_arch_boardgame
{
    /**
     * This subclass violates the Liskov Substitution Principle.
     * It is not substitutable for its parent type. Any class
     * that uses a two-dimensional Board would be very confused
     * by the ThreeDBaord.
     */
    public class ThreeDBoard : Board
    {
        // Height and Width are inherited already
        public int Zpos { get; }

        // The Tiles[,] from board is not helpful for three dimensions
        private Tile[,,] tiles;

        public ThreeDBoard(int width, int height, int zpos) : base(width, height)
        {
            Zpos = zpos;
            tiles = new Tile[width, height, zpos];
        }

        /**
         * Working with a third dimension requires a whole set
         * of new methods. But the two-dimensional versions
         * are still inherited and are available to call for
         * ThreeDBoards.
         */
        public Tile GetTile(int x, int y, int z)
        {
            return tiles[x,y,z];
        }

        public void AddGamePiece(GamePiece gamePiece, int x, int y, int z)
        {
            tiles[x,y,z].AddGamePiece(gamePiece);
        }

        public void RemoveGamePiece(GamePiece gamePiece, int x, int y, int z)
        {
            tiles[x,y,z].RemoveGamePiece(gamePiece);
        }

        public void RemoveGamePieces(int x, int y, int z)
        {
            tiles[x,y,z].RemoveGamePieces();
        }

        public List<GamePiece> GetGamePieces(int x, int y, int z)
        {
            return tiles[x,y,z].GetGamePieces();
        }
    }
}
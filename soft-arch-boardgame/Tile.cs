using System.Collections.Generic;

namespace soft_arch_boardgame
{
    /**
     * This class represents a tile in a board game board.
     * It may hold zero or more GamePiece objects.
     */
    public class Tile
    {
        private List<GamePiece> gamePieces = new List<GamePiece>();

        public void AddGamePiece(GamePiece gamePiece)
        {
            gamePieces.Add(gamePiece);
        }

        public void RemoveGamePiece(GamePiece gamePiece)
        {
            gamePieces.Remove(gamePiece);
        }

        public void RemoveGamePieces()
        {
            gamePieces.Clear();
        }

        public List<GamePiece> GetGamePieces()
        {
            // Copy into a new list so as not to expose the original
            return new List<GamePiece>(gamePieces);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame.BL
{
    public class Player
    {
        private GameBoard _gameBoard;

        public Player(GameBoard gameBoard)
        {
            _gameBoard = gameBoard;
        }

        public void PlaceOnBoard(Coordinate coordinate)
        {
            _gameBoard.SetPlayerPosition(coordinate);
        }
        public void MoveRight()
        {
            _gameBoard.MovePlayerRight();            
        }
        public void MoveLeft()
        {
            _gameBoard.MovePlayerLeft();
        }
        public void MoveTop()
        {
            _gameBoard.MovePlayerTop();
        }
        public void MoveBottom()
        {
            _gameBoard.MovePlayerBottom();
        }
    }
}

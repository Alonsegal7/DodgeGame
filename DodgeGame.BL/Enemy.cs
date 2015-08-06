using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame.BL
{
    public class Enemy
    {
        private GameBoard _gameBoard;

        public Enemy(GameBoard gameBoard)
        {
            _gameBoard = gameBoard;
        }

        public void PlaceOnBoard(Coordinate coordinate)
        {
            _gameBoard.SetEnemyPosition(coordinate);
        }

        public void MoveRight()
        {
            _gameBoard.MoveEnemyRight();            
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame.BL
{
    public class GameBoard
    {
        private Coordinate _playerPosition;
        private List<Coordinate> _enemiesPositions = new List<Coordinate>();
        private int _size;

        public GameBoard(int size)
        {
            _size = size;
        }

        public void SetPlayerPosition(Coordinate coordinate)
        {
            _playerPosition = coordinate;
        }

        public void SetEnemyPosition(Coordinate coordinate)
        {
            _enemiesPositions.Add(coordinate);
        }

        internal void MovePlayerRight()
        {
            if (_playerPosition.X < _size - 1)
            {
                _playerPosition.X += 1;
            }
        }

        internal void MoveEnemyRight()
        {
            var enemy = _enemiesPositions[0];
            if (enemy.X < _size - 1)
            {
                enemy.X += 1;
            }
        }
    }
}

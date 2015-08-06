using DodgeGame.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame.UI.Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application bootstrapping
            var gameBoard = new GameBoard(10);
            var player = new Player(gameBoard);
            var enemy1 = new Enemy(gameBoard);
            var enemy2 = new Enemy(gameBoard);


            //
            player.PlaceOnBoard(new RandomCoordinateGenerator().GenerateRandomPosition());
            enemy1.PlaceOnBoard(new RandomCoordinateGenerator().GenerateRandomPosition());
            enemy2.PlaceOnBoard(new RandomCoordinateGenerator().GenerateRandomPosition());

            player.MoveRight();
            enemy1.MoveRight();
            enemy2.MoveRight();
                
            Console.ReadLine();
        
        }
    }
}

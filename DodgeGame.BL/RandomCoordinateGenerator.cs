using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame.BL
{
    public class RandomCoordinateGenerator
    {
        public Coordinate GenerateRandomPosition()
        {
            Random r1 = new Random();
            var randomX = r1.Next(10);
            var randomY = r1.Next(10);

            return new Coordinate { X = randomX, Y = randomY };
        } 
    }
}

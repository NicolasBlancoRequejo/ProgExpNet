using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectinitialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Balloon balloon1 = new Balloon();
            Balloon balloon2 = balloon1;
                      
        }

        Balloon[] CreateBalloonArray()
        {
            var balloons = new Balloon[3];

            balloons[0] = new Balloon();
            balloons[0].X = 10;
            balloons[0].Y = 10;
            balloons[0].Diameter = 40;
            balloons[0].Color = "Red";
            balloons[1] = new Balloon();
            balloons[1].X = 14;
            balloons[1].Y = 50;
            balloons[1].Diameter = 400;
            balloons[1].Color = "Green";
            balloons[2] = new Balloon();
            balloons[2].X = 30;
            balloons[2].Y = 80;
            balloons[2].Diameter = 4000;
            balloons[2].Color = "Blue";

            return balloons;
        }

        Balloon[] CreateBalloonArrayShorter()
        {
            var balloons = new Balloon[3];

            balloons[0] = new Balloon() { X = 10, Y = 10, Diameter = 40, Color = "Red" };
            balloons[1] = new Balloon { X = 14, Y = 50, Diameter = 400, Color = "Green" };
            balloons[2] = new Balloon
            {
                X = 30,
                Y = 80,
                Diameter = 4000,
                Color = "Blue"
            };

            return balloons;
        }

        Balloon[] CreateBalloonArrayShortest()
        {
            var balloons = new Balloon[]
            {
                new Balloon
                {
                    X = 10,
                    Y = 10,
                    Diameter = 40,
                    Color = "Red"
                },
                new Balloon
                {
                    X = 14,
                    Y = 50,
                    Diameter = 400,
                    Color = "Green"
                },
                new Balloon
                {
                    X = 30,
                    Y = 80,
                    Diameter = 4000,
                    Color = "Blue"
                }
            };
            return balloons;
        }
    }
}

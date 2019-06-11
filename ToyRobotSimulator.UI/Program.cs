using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotSimulator.Core;

namespace ToyRobotSimulator.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ToyRobot tRobot1 = new ToyRobot(5, 5);

                Console.WriteLine("PLACE (0,0,NORTH)");
                tRobot1.Place(0, 0, Directions.North);

                Console.WriteLine(tRobot1.Report());

                Console.WriteLine("MOVE");
                tRobot1.Move();

                Console.WriteLine(tRobot1.Report());

                Console.WriteLine();
                Console.WriteLine();

                ToyRobot tRobot2 = new ToyRobot(5, 5);

                Console.WriteLine("PLACE (0,0,NORTH)");
                tRobot2.Place(0, 0, Directions.North);

                Console.WriteLine(tRobot2.Report());

                Console.WriteLine("MOVE");
                tRobot2.Left();

                Console.WriteLine(tRobot2.Report());

                Console.WriteLine();
                Console.WriteLine();

                ToyRobot tRobot3 = new ToyRobot(5, 5);

                Console.WriteLine("PLACE (1,2,EAST)");
                tRobot3.Place(1, 2, Directions.East);

                Console.WriteLine(tRobot3.Report());

                Console.WriteLine("MOVE");
                tRobot3.Move();

                Console.WriteLine(tRobot3.Report());

                Console.WriteLine("MOVE");
                tRobot3.Move();

                Console.WriteLine(tRobot3.Report());

                Console.WriteLine("LEFT");
                tRobot3.Left();

                Console.WriteLine(tRobot3.Report());

                Console.WriteLine("MOVE");
                tRobot3.Move();

                Console.WriteLine(tRobot3.Report());

                Console.WriteLine();
                Console.WriteLine();

                Console.ReadKey();
            }
            catch (Exception)
            {

            }
        }
    }
}

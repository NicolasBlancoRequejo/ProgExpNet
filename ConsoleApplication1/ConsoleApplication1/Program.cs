using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApplication1
{
    class Program
    {
        static System.Timers.Timer timer;
        static void Main(string[] args)
        {
            timer = new System.Timers.Timer(10000); //Timer van 10 seconden
            timer.Elapsed += OnTimedEvent; //Event gaat af nadat de timer over is
            timer.Enabled = true; //Timer aanzetten
            Console.WriteLine("Solving hard sudoku...");
            Thread.Sleep(30000);
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            timer.Enabled = false;
            Console.WriteLine("Warning: The solving of the hard sudoku puzzles seems to take too long to resolve.");
            Console.WriteLine("Perhaps your PC is underperforming and this task may take a longer time.");
            string response = "";
            while (response.ToLower() != "y" && response.ToLower() != "n")
            {
                Console.WriteLine("Do you want to continue? Y / N");
                response = Console.ReadLine();
            }
            if (response.ToLower() == "y")
            {
                solveHardSudoku();
            }
            else
            {
                closeProgram();
            }
        }

        public static void closeProgram()
        {
            Console.WriteLine("Succesfully closed the program.");

        }

        public static void solveHardSudoku()
        {
            Console.WriteLine("Solving the Hard puzzle.");
        }
    }
}

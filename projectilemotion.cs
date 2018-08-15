/* Author: Daniel "Danny" Rogers
 * Description: This C# program gives stats for a launched projectile's
 *              motion (assuming no air resistance). The program displays
 *              when the projectile will land, the range of the projectile,
 *              and where the projectile is at time t (input).
 */

using System;

namespace ProjectileMotion
{

    class LaunchedObject
    {
        public double Velocity;
        public double Angle;

        public LaunchedObject(double vel, double ang)
        {
            Velocity = vel;
            Angle = Math.PI * ang / 180; // Convert to radians
        }
     }

    class Program
    {
        static double velInput, angInput, time, xpos, ypos, xComp, yComp, timeToLand, range;
        static string exitchoice;
        /*
        private static void checkInput(double myvar)
        {
            if (!double.TryParse(Console.ReadLine(), out myvar)
            {
                Console.WriteLine("ERR: invaid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        */

        private static void getTime()
        {
            if (!double.TryParse(Console.ReadLine(), out time))
            {
                Console.WriteLine("ERROR: invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        private static void getVelocity()
        {
            if (!double.TryParse(Console.ReadLine(), out velInput))
            {
                Console.WriteLine("ERROR: invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        private static void getAngle()
        {
            if (!double.TryParse(Console.ReadLine(), out angInput))
            {
                Console.WriteLine("ERROR: invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Program Start~~~~~~~~~~~~~~~~~~~");
            Console.Write("Enter the intial velocity (m/s) of the projectile: ");
            getVelocity();
            ////checkInput(velInput);
            Console.Write("Enter the angle (°) of the launch: ");
            getAngle();

            LaunchedObject obj1 = new LaunchedObject(velInput, angInput);
            xComp = obj1.Velocity * Math.Cos(obj1.Angle);
            yComp = obj1.Velocity * Math.Sin(obj1.Angle);

            timeToLand = 2 * (yComp / (9.81));
            range = xComp * timeToLand;

            Console.WriteLine("The projectile will hit the ground in {0} seconds.", Math.Round(timeToLand, 5));
            Console.WriteLine("The projectile will travel {0} meters.", Math.Round(range, 5));
            exitchoice = Console.ReadLine();

            while (exitchoice != "exit")
            {
                Console.Write("Analyze the projectile at time t=");
                getTime();

                xpos = xComp * time;
                ypos = yComp * time - 0.5 * 9.81 * Math.Pow(time, 2);

　
                Console.WriteLine("Stats for the {0}-second mark:", time);
                Console.WriteLine("Horizontal displacement: {0} meters", Math.Round(xpos, 3));
                Console.WriteLine("Vertical displacement: {0} meters", Math.Round(ypos, 3));
                Console.WriteLine();
                Console.WriteLine("Horizontal velocity: {0} m/s", Math.Round(xComp, 5));
                Console.WriteLine("Vertical velocity: {0} m/s", Math.Round(yComp, 5));
                exitchoice = Console.ReadLine();
            }
            // i need more computational physics ideas
        }
    }
}

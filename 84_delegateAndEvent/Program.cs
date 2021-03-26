using System;
using System.Timers;

namespace _84_delegateAndEvent
{



    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            var interval = 500;
            timer.Interval = interval;
            timer.Start();

            Console.ReadKey();

            Car car = new Car();
            car.tooFastHandler += HandlerOnTooFast;
            car.tooFastHandler += HandlerOnTooFast;

            car.tooFastHandler -= HandlerOnTooFast;

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            int x = 32;
            object hell = null;
            Console.WriteLine(hell);

            Car car2 = null;
            Console.WriteLine(car2);

        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Handling Timer Elapsed Event");
        }

        public static void HandlerOnTooFast(object obj, CarArgs carArgs)
        {
            Console.WriteLine($"Oh, I got it! Calling stop! Current Speed = {carArgs.CurrentSpeed}");
            if(obj is Car car)
            {
                car.Stop();
            }
        }
    }

    
}

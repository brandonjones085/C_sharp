using System;


namespace ConsoleApp13
{
    class Stopwatch
    {
        private bool _running;
        private DateTime _startStopwatch;
        private DateTime _stopStopwatch;

        public void begin()
        {

            if (_running)
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
            else
            {
                _startStopwatch = DateTime.Now;
                _running = true;

                Console.WriteLine("Stopwatch started at {0}. Press any key to stop. ", _startStopwatch);
            }
           
        }

        public void stop()
        {
            _running = false;
            _stopStopwatch = DateTime.Now;

            Console.Write("Stopwatch stopped at {0}", _stopStopwatch);
        }

        public TimeSpan duration()
        {
           var time = _stopStopwatch - _startStopwatch;

            return time;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            var stopwatch = new Stopwatch();

            Console.WriteLine("Press any key to start the stopwatch");
            var chi = Console.ReadKey(); 
          
            stopwatch.begin();
            var chi1 = Console.ReadKey();

            stopwatch.stop();
            Console.WriteLine();
            Console.WriteLine("The time elapsed: {0}", stopwatch.duration());

            Console.WriteLine();
            

        }
    }
}

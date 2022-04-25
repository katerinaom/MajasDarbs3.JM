namespace MajasDarbs3.JM
{
    public class Car
    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public double Speed { get; set; }

        public void StartToDrive()
        {
            Speed = 90;
            Console.WriteLine("Let's go! ");
        }

        public double GoFaster()
        {
            Speed += 10;
            Console.WriteLine("Speed - " + Speed);
            return Speed;
        }

        public void Beep()
        {
            Console.WriteLine("Beep Beep Beeeeeeeep !!!");
        }

        public double SlowDown()
        {
            Speed -= 40;
            Console.WriteLine("Speeed - " + Speed);
            return Speed;
        }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Stopped...");
        }



    }
}

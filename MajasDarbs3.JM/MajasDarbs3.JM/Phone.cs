namespace MajasDarbs3.JM
{
    public class Phone
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Size { get; set; }

        public void Call()
        {
            Console.WriteLine("Calling");
        }
        public void Sms()
        {
            Console.WriteLine("SMS sent");
        }




    }
}

namespace MajasDarbs3.JM
{
    public class Product
    {
        public Product(double MaxValue)
        {
            Height = 100;
            Length = 200;
            Width = 80;
            Weight = 50;
        }
        public double Height { get; }
        public double Length { get; }
        public double Width { get; }
        public double Weight { get; }

        public void HeightSize()
        {
            Height = 100;
            Console.WriteLine($"{Product} height is {Height}");
        }

        public void Length()
        {
            
        }

        public void Width()
        {
            
        }

        public double Weidth()
        {
            
        }

        public void Stop()
        {
        }


    }
}

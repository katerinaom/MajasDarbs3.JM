namespace MajasDarbs3.JM
{
    public class Product
    {
        public string Name { get; set; }

        public double Height { get; } = 100;
        public double Length { get; } = 200;
        public double Width { get; } = 80;
        public double Weight { get; } = 40;

        public void Buy()
        {
            Console.WriteLine($"Want to buy {Name} ");
        }

        public void Size()
        {
            Console.WriteLine($"The {Name} size is: Height = {Height}, length = {Length}, width = {Width} and weight = {Weight}. ");
        }








    }







}

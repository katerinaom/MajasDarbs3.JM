namespace MajasDarbs3.JM
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double BirthDate { get; set; }

        public string Hobby { get; set; }
        public bool Gender { get; set; }

        public int GetAge()

        { int age = DateTime.Now.Year - BirthDate.Year;
            Console.WriteLine(age);


            return age;

        }





    }
}

namespace MajasDarbs3.JM
{
    public class Person
    {
        public bool Gender { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
     

        public int GetAge() 
        { return DateTime.Now.Year - BirthDate.Year -1; }








    }
}

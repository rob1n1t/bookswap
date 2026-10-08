namespace Models
{
    public class Student
    {
        public string Fornamn { get; private set; }
        public string Efternamn { get; private set; }
        public string Telefonnummer { get; private set; }

        public Student(
            string fornamn,
            string efternamn,
            string telefonnummer)
        {
            Fornamn = fornamn;
            Efternamn = efternamn;
            Telefonnummer = telefonnummer;
        }
    }
}

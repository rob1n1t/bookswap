namespace Models
{
    public class Student
    {
        public string Förnamn { get; private set; }
        public string Efternamn { get; private set; }
        public string Telefonnummer { get; private set; }

        public Student(
            string förnamn,
            string efternamn,
            string telefonnummer)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
            Telefonnummer = telefonnummer;
        }
    }
}

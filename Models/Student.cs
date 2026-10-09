using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student: Användare
    {
        public Student(string förnamn,string efternamn,string telefonnummer,Kontouppgifter kontouppgifter)
            : base(förnamn, efternamn, telefonnummer, kontouppgifter)
        { }
    }
}

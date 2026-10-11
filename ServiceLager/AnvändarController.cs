using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLager
{
    public class AnvändarController
    {
        private BookSwapRegister Register;

        public AnvändarController(BookSwapRegister register)
        {

            Register = register;
        }

        public Student RegistreraStudent(string förnamn, string efternamn,
             string epost, string telefonnummer, string lösenord)
        {
            if (string.IsNullOrWhiteSpace(förnamn))
                throw new ArgumentException("Förnamn måste anges.");
            if (string.IsNullOrWhiteSpace(efternamn))
                throw new ArgumentException("Efternamn måste anges.");
            if (string.IsNullOrWhiteSpace(telefonnummer))
                throw new ArgumentException("Telefonnummer måste anges.");

            string trimmatFörnamn = förnamn.Trim();
            string trimmatEfternamn = efternamn.Trim();
            string trimmatTelefonnummer = telefonnummer.Trim();

            // Kontroll att epost och lösen inte är tomma
            Kontouppgifter kontouppgifter = new Kontouppgifter(epost, lösenord);

            if (Register.HittaAnvändareViaEpost(kontouppgifter.Epostadress) != null)
                throw new ArgumentException("E-postadressen används redan av ett annat konto.");

            Student nyStudent = new Student(trimmatFörnamn, trimmatEfternamn, trimmatTelefonnummer, kontouppgifter);
            Register.LäggTillAnvändare(nyStudent);

            return nyStudent;
        }
    }
}

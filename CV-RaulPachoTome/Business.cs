using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_RaulPachoTome
{
    class Business
    {
        public string Position { get; set; }
        public string Company { get; set; }
        public string Place { get; set; }
        public string[] GainedExperience { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Business(string position, string company, string place, string[] gainedExperience, DateTime start, DateTime end)
        {
            Position = position;
            Company = company;
            Place = place;
            GainedExperience = gainedExperience;
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            string experience = "";
            
            experience += String.Format("Puesto: {0}\n", Position);
            experience += String.Format("Empresa: {0}\n", Company);
            experience += String.Format("Lugar: {0}\n", Place);
            experience += "Conocimientos Adquiridos: \n";

            for (int i = 0; i < GainedExperience.Length; i++)
            {
                experience += String.Format("\t {0}\n", GainedExperience[i]);
            }

            experience += String.Format("Comienzo: {0}\n", Start.ToString("dd/MM/yyyy"));
            experience += String.Format("Fin: {0}\n", End.ToString("dd/MM/yyyy"));
            experience += "\n";
            
            return experience;
        }
    }
}

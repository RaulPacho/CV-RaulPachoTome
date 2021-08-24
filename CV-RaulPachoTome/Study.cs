using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_RaulPachoTome
{
    class Study
    {
        public string Title { get; set; }
        public string Institute { get; set; }
        public string Place { get; set; }
        public string[] Aptitudes { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Study(string title, string institute, string place, string[] aptitudes, DateTime start, DateTime end)
        {
            Title = title;
            Institute = institute;
            Place = place;
            Aptitudes = aptitudes;
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            string studies = "";

            studies += String.Format("Título: {0}\n", Title);
            studies += String.Format("Instituto: {0}\n", Institute);
            studies += String.Format("Lugar: {0}\n", Place);
            studies += "Conocimientos adquiridos: \n";
            foreach (string aptitude in Aptitudes)
            {
                studies += $"\t {aptitude} \n";
            }
            studies += String.Format("Comienzo: {0}\n", Start.ToString("dd/MM/yyyy"));
            studies += String.Format("Fin: {0}\n\n", End.ToString("dd/MM/yyyy"));
            
            return studies;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace CV_RaulPachoTome
{
    class Program
    {
        private List<Business> laboralExperience = new List<Business>();
        private List<Study> completedStudies = new List<Study>();
        private string[] extraQualifications;
        static void Main(string[] args)
        {
            Program p = new Program();
            
            p.ShowEverything();
        }

        public void ShowEverything()
        {
            RaulPacho rp = new RaulPacho();
            FullfillExperience();
            FullfillStudies();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("===Información Personal===\n");
            ShowInAFashionWay(rp.ToString());
            Console.Write("===Experiencia===\n");

            foreach (Business b in laboralExperience)
                ShowInAFashionWay(b.ToString());

            Console.Write("===Estudios===\n");

            foreach (Study s in completedStudies)
            {
                ShowInAFashionWay(s.ToString());
            }

            Console.ReadLine();
        }

        private void FullfillExperience()
        {
            laboralExperience.Add(new Business
            (
                position: "Programador",
                company: "Freelance",
                place: "Vigo",
                gainedExperience: new string[] {"Desarrollo de aplicaciones móviles", "Flutter", "Dart", "Firebase",
                                    "Relación con clientes",
                                    "Elaboración de presupuestos y plazos" },
                start: new DateTime(2021, 7, 1),
                end: DateTime.Now
            ));

            laboralExperience.Add(new Business
            (
                position: "Programador en prácticas",
                company: "Novos S.L.",
                place: "Vigo",
                gainedExperience: new string[] {"Desarrollo FullStack", 
                                    "SQL Server", "C# con Entity Framework", 
                                    "Vue.js", "JavasCript", "TypeScript", "HTML", "CSS (Bulma)",
                                    "Estructuración de la empresa",
                                    "Segmentación y trabajo en equipo en un programa" },
                start: new DateTime(2021, 4, 14),
                end: new DateTime(2021,6,18)
            ));

            laboralExperience.Add(new Business
            (
                position: "Técnico en seguridad informática en prácticas",
                company: "Xilon S.L.",
                place: "Vigo",
                gainedExperience: new string[] {"Mantenimiento informático",
                                    "Gestión de red",
                                    "Seguridad en VoIP",
                                    "Gestión de sistemas Linux"},
                start: new DateTime(2017, 9, 1),
                end: new DateTime(2017, 12, 31)
            ));

            laboralExperience.Add(new Business
            (
                position: "Soporte Técnico",
                company: "Microasis S.L.",
                place: "Vigo",
                gainedExperience: new string[] {"Atención al cliente",
                                    "Resolución de errores en tiempo real",
                                    "Administración de redes y dispositivos",
                                    "Formación de nuevos usuarios"},
                start: new DateTime(2017, 9, 1),
                end: new DateTime(2017, 12, 31)
            ));
        }
        public void FullfillStudies()
        {
            completedStudies.Add(new Study (
                title: "Desarrollo de aplicaciones multiplataforma",
                institute: "Colegio Vivas",
                place: "Vigo",
                aptitudes: new string[]
                {
                    "Programación en Java",
                    "Programación en C#",
                    "Programación en JavaScript",
                    "Programación en PHP",
                    "Diseño con HTML y CSS",
                    "Uso de servicios REST",
                    "Uso de bases de datos (mysql, sqlite...)",
                    "Uso de frameworks (laravel)",
                    "Formación y orientación laboral e iniciativa emprendedora"
                },
                start: new DateTime(2019,9,12),
                end: new DateTime(2021, 6, 18)
            ));

            completedStudies.Add(new Study(
                title: "Carrera de Ciberseguridad",
                institute: "OpenWebinars",
                place: "Vigo",
                aptitudes: new string[]
                {
                    "Queda por buscar",
                },
                start: new DateTime(2021, 4, 14),
                end: new DateTime(2021, 6, 18)
                ));

            completedStudies.Add(new Study(
                title: "Certificado de profesionalidad de fundamentos de la gestión TIC de Microsoft",
                institute: "Academia Postal",
                place: "Vigo",
                aptitudes: new string[]
                {
                    "Administración de redes",
                    "Administración de Windows Server",
                    "Administración de servicios de nube(Owncloud, nextcloud, onedrive, office365)",
                    "Configuración de servicios Windows",
                },
                start: new DateTime(2016, 12, 13),
                end: new DateTime(2017, 04, 17)
                ));

            completedStudies.Add(new Study(
                title: "Certificado de profesionalidad en seguridad informática",
                institute: "Academia Postal",
                place: "Vigo",
                aptitudes: new string[]
                {
                    "Seguridad informática en redes",
                    "Administración y seguridad de routers y switchs Cisco",
                    "Analisis de vulnerabilidades",
                    "Protección frente a vulnerabilidades"
                },
                start: new DateTime(2021, 4, 14),
                end: new DateTime(2021, 6, 18)
                ));
        }
       
        public void ShowInAFashionWay(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            
        }
    }
}

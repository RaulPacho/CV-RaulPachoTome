using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_RaulPachoTome
{
    class RaulPacho
    {
        public const string Nombre = "Raul Pacho Tome"; 
        public const string Address = "c/Brasil, 50, 2ºD";
        public const string Email = "raul.pacho94@gmail.com";
        public const int Phone = 645684429;

        
        public override string ToString()
        {
            return $"{Nombre}\n" +
                $"Dirección: {Address}\n" +
                $"Email: {Email}\n" +
                $"Teléfono: {Phone}\n\n";
        }
    }
}

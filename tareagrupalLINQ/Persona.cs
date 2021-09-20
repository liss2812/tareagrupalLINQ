using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareagrupalLINQ
{
    class Persona
    {
        public int DNIPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string SignoZodiacal { get; set; }

        public string Pais { get; set; }
        public int Edad { get; set; }
        public string EstadoCivil { get; set; }


        public static List<Persona> GetPersonas()
        {
            List<Persona> personas = new List<Persona>
            {
            new Persona{ DNIPersona=06318407-4, Nombre="Fatima ", Apellidos="Guzman Trejo" ,SignoZodiacal="Virgo", Pais="Panama", Edad=20, EstadoCivil="Soltera" },
            new Persona{ DNIPersona=06318411-2, Nombre="Liseth ", Apellidos="Paz Coreas" ,SignoZodiacal="Acuario", Pais="Mexico", Edad=19,  EstadoCivil="Casada" },
            new Persona{ DNIPersona=06318422-7, Nombre="Sofia ", Apellidos="Membreño Antonio" ,SignoZodiacal="Cancer", Pais="Canada", Edad=18, EstadoCivil="Viuda" },
            new Persona{ DNIPersona=06318457-1, Nombre="Samuel ", Apellidos="Guerra Chicas" ,SignoZodiacal="Tauro", Pais="El Salvador", Edad=21,EstadoCivil="Soltero" },
            new Persona{ DNIPersona=06318205-4, Nombre="Jose ", Apellidos="Rivera Zanchez" ,SignoZodiacal="Capricornio", Pais="Peru", Edad=22,EstadoCivil="Casado" }
            };

            return personas;
        }

        internal static object ThenBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }

}

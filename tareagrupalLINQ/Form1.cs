using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tareagrupalLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SelectNombre();
        }

        private void SelectNombre()
        {
            List<string> query = (
                from persona in Persona.GetPersonas()
                select persona.Nombre 

                 
                ).ToList();

            foreach (var nombre in query)
            {
                Nombres.Items.Add(nombre);
                
            }


        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            datos.Columns.Add("DNIPersona", "NUMERO UNICO DE IDENTIDAD");
            datos.Columns.Add("Nombre", " NOMBRE");
            datos.Columns.Add("Apellidos", "APELLIDOS");
            datos.Columns.Add("SignoZodiacal", "SIGNO");
            datos.Columns.Add("pais", "PAIS");
            datos.Columns.Add("Edad", "EDAD");
            datos.Columns.Add("EstadoCivil", "ESTADO");

           





            foreach (var persona in selecdatos())

            {
                datos.Rows.Add(persona.DNIPersona, persona.Nombre, persona.Apellidos, persona.SignoZodiacal, persona.Pais, persona.Edad, persona.EstadoCivil);
            }
        }

        private List<Persona>selecdatos()
        {
            List<Persona> query = (
                from persona in Persona.GetPersonas()
                select new Persona()
                {
  DNIPersona = persona.DNIPersona,
  Nombre = persona.Nombre,
  Apellidos = persona.Apellidos,
  SignoZodiacal = persona.SignoZodiacal,
  Pais = persona.Pais,
  Edad = persona.Edad,
  EstadoCivil = persona.EstadoCivil
                }
                
                ).ToList();
            return query;

          


        }
    }
}

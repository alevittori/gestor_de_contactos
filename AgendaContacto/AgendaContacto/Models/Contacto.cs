using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContacto.Models
{
    public class Contacto
    {
        string nombre, apellido, telefono, mail, dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; } //validar mail
        public string Dni { get => dni; set => dni = value; } //validar dni 


        public Contacto() { }

        public Contacto(string nombre, string apellido, string tel, string mail,string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = tel;
            Mail = mail;
            Dni = dni;
        }


        public override string ToString()
        {
            return $"{Nombre};{Apellido};{Telefono}";
        }
    }
}

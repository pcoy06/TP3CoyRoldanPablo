using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad3
{
    class Persona
   {
        //declaramos los atributos
        private string nombre;
        private string email;
        private int sueldo;
        private string sexo;
        private int peso;
        private double altura;

        // declaramos el constructor
        public Persona(string nombre, int sueldo, string sexo, int peso, double altura)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
            this.email = CrearEmail();
                         
        }
        
        

        // Método para concatenar el nombre que carguen,con el correo
        private string CrearEmail()
        {
            return nombre + "@superempresa.com";
        }

        public string getEmail()
        {
            return email;
        }

        public string getNombre()
        {
            return nombre;
        }
        public int getSueldo()
        {
            return sueldo;
        }
        
        public string getSexo()
        {
            return sexo;
        }
        public int getPeso()
        {
            return peso;
        }
        public double getAltura()
        {
            return altura;
        }              

    }
}

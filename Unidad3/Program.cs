using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            //string email;
            int sueldo;
            string sexo;
            int peso;
            double altura;

            Console.WriteLine("-----------Bienvenido al Registro de Personas:---------- ");
            Console.WriteLine("");
            Console.Write("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("De cuanto es su sueldo?: ");
            sueldo = int.Parse(Console.ReadLine());
            Console.Write("¿Cual es su sexo?: ");
            sexo = Console.ReadLine();
            Console.Write("¿Cual es su Peso actual?: ");
            peso = int.Parse(Console.ReadLine());
            Console.Write("¿Cual es su altura?: ");
            altura = double.Parse(Console.ReadLine());

            Persona persona = new Persona(nombre, sueldo, sexo, peso, altura);
            
            
            Console.WriteLine("");
            Console.WriteLine("** Muchas gracias, estos serían sus datos cargados: ");
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + persona.getNombre() + "\nEmail: " + persona.getEmail() + "\nSueldo: " + persona.getSueldo() + " ARS" +  
                "\nSexo: " + persona.getSexo() + "\nPeso: " + persona.getPeso() + " Kg" + "\nAltura: " + persona.getAltura() + " Mts.");

            Console.ReadKey();

        }
        




    }
    
        

}



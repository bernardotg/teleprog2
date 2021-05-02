using System;

namespace Veterinaria
{
    class Animales
    {
        private string nombre;
        private string especie;
        private string sexo;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }


        public void LeerEspecie()
        {
            Console.WriteLine("Ingrese la especie del paciente: ");
            Especie = Console.ReadLine();
        }

        public void LeerSexo()
        {
            Console.WriteLine("Ingrese el sexo del paciente: ");
            Sexo = Console.ReadLine();
        }

        public void LeerNombre()
        {
            Console.WriteLine("Ingrese el nombre del paciente: ");
            Nombre = Console.ReadLine();
        }

        public void LeerEdad()
        {
            do
            {
                Console.WriteLine("Ingrese la edad del paciente: ");
                Edad = int.Parse(Console.ReadLine());
            } while (Edad < 0);
        }

        public void Imprimir()
        {
            Console.WriteLine("Datos del paciente: ");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Especie: " + Especie);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Edad: " + Edad);
        }
    }
    class Perro : Animales
    {
        private string raza;
        private string perrarina;

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public string Perrarina
        {
            get { return perrarina; }
            set { perrarina = value; }
        }

        public void LeerRaza()
        {
            Console.WriteLine("Ingrese la raza del paciente: ");
            Raza = Console.ReadLine();
        }

        public void LeerPerrarina()
        {
            Console.WriteLine("Ingrese su perrarina favorita ");
            Perrarina = Console.ReadLine();
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Raza: " + Raza);
            Console.WriteLine("Perrarina: " + Perrarina);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Perro perro1 = new Perro();
            perro1.LeerEspecie();
            perro1.LeerSexo();
            perro1.LeerNombre();
            perro1.LeerEdad();
            perro1.LeerRaza();
            perro1.LeerPerrarina();
            perro1.Imprimir();

            Console.ReadKey();
        }
    }
}
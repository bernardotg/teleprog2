using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Controlador
    {
        static void Main(string[] args)
        {
            Controlador c = new Controlador();
        }

        private Vista entrada;
        public Controlador()
        {
            entrada = new Vista();

            if (entrada.Origen == 1)
            {
                Dolar salida;
                salida = new Dolar();
                salida.Cantidad = entrada.Ca;
                entrada.Cam = salida.Cambio;
                entrada.Total = (long)salida.calcular();
                entrada.imprimir();
            }
            else if (entrada.Origen == 2)
            {
                PesoCol salida;
                salida = new PesoCol();
                salida.Cantidad = entrada.Ca;
                entrada.Cam = salida.Cambio;
                entrada.Total = (long)salida.calcular();
                entrada.imprimir();
            }
            else if (entrada.Origen == 3)
            {
                SolPe salida;
                salida = new SolPe();
                salida.Cantidad = entrada.Ca;
                entrada.Cam = salida.Cambio;
                entrada.Total = (long)salida.calcular();
                entrada.imprimir();
            }
        }
    }

    class Modelo
    {   
        private float cambio;
        private float cantidad;

        public Modelo() { }
        public Modelo(float cam, float ca)
        {
            Cambio = cam;
            Cantidad = ca;
        }

        public float Cambio
        {
            get { return cambio; }
            set { cambio = value; }
        }

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public float calcular()
        {
            return Cambio * Cantidad;
        }
    }

    class Dolar : Modelo
    { 
        public Dolar()
        {
            Cambio = 4200000;
            Cantidad = 0;
        }

        public Dolar(float cam, float ca)
        {
            Cambio = cam;
            Cantidad = ca;
        }

    }

    class PesoCol : Modelo
    {
        public PesoCol()
        { 
            Cambio = 1050;
        }

        public PesoCol(float cam, float ca)
        {
            Cambio = cam;
            Cantidad = ca;
        }
    }

    class SolPe : Modelo
    {   //constructores
        public SolPe()
        {
            Cambio = 995920;
        }

        public SolPe(float cam, float ca)
        {
            Cambio = cam;
            Cantidad = ca;
        }
    }

    class Vista
    {
        private int origen;
        private float cam;
        private float ca;
        private float total;

        public float Cam
        {
            get { return cam; }
            set { cam = value; }
        }

        public float Ca
        {
            get { return ca; }
            set { ca = value; }
        }

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        public int Origen
        {
            get { return this.origen; }
            set { this.origen = value; }
        }

        public Vista()
        {
            this.Datos();
        }
        private void Datos()
        {
            Console.WriteLine("¿Que moneda va a convertir? 1-Dolar 2-Peso colombiano 3-Sol peruano");
            switch (Console.ReadLine())
            {
                case "1":

                    this.Origen = 1;
                    break;
                case "2":

                    this.Origen = 2;
                    break;
                case "3":

                    this.Origen = 3;
                    break;
            }
            Console.WriteLine("Monto: ");
            ca = Single.Parse(Console.ReadLine());
        }

        public void imprimir()
        { 
            Console.WriteLine("El resultado es: " + Total);
            Console.ReadKey();
        }
    }
}
using System;

namespace Figuras
{
    class Figuras
    {
        //clase; declaracion de datos
        private float perimetro;
        private float area;

        //funciones de acceso

        public float perimetro_
        {
            get { return perimetro; }
            set { perimetro = value; }
        }

        public float area_
        {
            get { return area; }
            set { area = value; }
        }

        //métodos de la clase
        public void lectura() { }
        public void calculara() { }
        public void calcularp() { }

        public void resultado()
        {
            Console.WriteLine("La figura contiene una tiene un perímetro de " + perimetro_ + " y un área de " + area_);
        }
    }

    class Circulo : Figuras
    {   //subclase; declaración de datos
        private float radio;

        //funciones de acceso
        public float radio_
        {
            get { return radio; }
            set { radio = value; }
        }

        //métodos nuevos
        new public void lectura()
        {
            Console.WriteLine("Radio del círculo: ");
            radio_ = Single.Parse(Console.ReadLine());
        }

        new public void calcularp()
        {
            perimetro_ = 6.28f * radio_;
        }

        new public void calculara()
        {
            area_ = 3.14f * radio_ * radio_;
        }

        private static int cantidad;

        public Circulo() //contador
        {
            cantidad++;
        }
        public static int getCantidad()
        {
            return cantidad;
        }
    }

    class Rectangulo : Figuras
    {   //subclase; declaración de datos
        private float Base;
        private float altura;

        //funciones de acceso
        public float Base_
        {
            get { return Base; }
            set { Base = value; }
        }

        public float altura_
        {
            get { return altura; }
            set { altura = value; }
        }
        //métodos nuevos
        new public void lectura()
        {
            Console.WriteLine("Base del rectángulo: ");
            Base_ = Single.Parse(Console.ReadLine());
            Console.WriteLine("Altura del rectángulo: ");
            altura_ = Single.Parse(Console.ReadLine());
        }

        new public void calcularp()
        {
            perimetro_ = (2 * Base_) + (2 * altura_);
        }

        new public void calculara()
        {
            area_ = Base_ * altura_;
        }

        private static int cantidad;

        public static int cantidad_
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Rectangulo()     //contador
        {
            cantidad++;
        }
        public static int getCantidad()
        {
            return cantidad;
        }
    }

    class Cuadrado : Rectangulo
    {   //subclase; declaración de datos

        //métodos nuevos
        new public void lectura()
        {
            Console.WriteLine("Lado del cuadrado: ");
            Base_ = Single.Parse(Console.ReadLine());
            altura_ = Base_;

        }       //para calcular área y perímetro no se escriben métodos nuevos porque los de métodos de la clase rectangulo  son aplicables

        private static int cantidad;

        public Cuadrado()   //contador
        {
            Rectangulo.cantidad_--;
            cantidad++;
        }
        new public static int getCantidad()
        {
            return cantidad;
        }
    }

    class Elipse : Figuras
    {   //subclase; declaración de datos
        private float eje1;
        private float eje2;
        //funciones de acceso
        public float eje1_
        {
            get { return eje1; }
            set { eje1 = value; }
        }

        public float eje2_
        {
            get { return eje2; }
            set { eje2 = value; }
        }
        //métodos nuevos
        new public void lectura()
        {
            Console.WriteLine("Primer eje de la elipse: ");
            eje1_ = Single.Parse(Console.ReadLine());

            Console.WriteLine("Segundo eje de la elipse: ");
            eje2_ = Single.Parse(Console.ReadLine());
        }

        new public void calcularp()
        {
            perimetro_ = 6.28f * (float)Math.Sqrt((eje2_ * eje2_ + eje1_ * eje1_) / 2);
        }

        new public void calculara()
        {
            area_ = 3.14f * eje2_ * eje1_;
        }

        private static int cantidad;

        public Elipse()     //contador
        {
            cantidad++;
        }
        public static int getCantidad()
        {
            return cantidad;
        }
    }

   class Triangulo : Figuras
        {   //subclase; declaración de datos
            private float ladoa;
            private float ladob;
            private float ladoc;
            private float Base;
            private float altura;

            public float la
            {
                get { return ladoa; }
                set { ladoa = value; }
            }

            public float lb
            {
                get { return ladob; }
                set { ladob = value; }
            }

            public float lc
            {
                get { return ladoc; }
                set { ladoc = value; }
            }

            public float Base_
            {
                get { return Base; }
                set { Base = value; }
            }

            public float altura_
            {
                get { return altura; }
                set { altura = value; }
            }
            //métodos nuevos
            new public void lectura()
            {
                Console.WriteLine("Primer lado del triángulo: ");
                la = Single.Parse(Console.ReadLine());

                Console.WriteLine("Segundo lado del triángulo: ");
                lb = Single.Parse(Console.ReadLine());

                Console.WriteLine("Tercer lado del triángulo: ");
                lc = Single.Parse(Console.ReadLine());
            }

            new public void calcularp()
            {
                perimetro_ = la + lb + lc;
            }

            new public void calculara()   
            {
                area_ = Base_ * altura_ / 2;
            }

            private static int cantidad;

            public Triangulo()  //contador
            {
                cantidad++;
            }
            public static int getCantidad()
            {
                return cantidad;
            }
        }
        //programa principal
        class Prueba
    {
        static void Main(string[] args)
        {    Circulo a = new Circulo();  //instancia
                    a.lectura();
                    a.calcularp();
                    a.calculara();
                    a.resultado();

            Rectangulo b = new Rectangulo();
                    b.lectura();
                    b.calcularp();
                    b.calculara();
                    b.resultado();

            Cuadrado c = new Cuadrado();
                    c.lectura();
                    c.calcularp();
                    c.calculara();
                    c.resultado();

            Elipse d = new Elipse();
                    d.lectura();
                    d.calcularp();
                    d.calculara();
                    d.resultado();

            Triangulo e = new Triangulo();
                    e.lectura();
                    e.calcularp();
                    e.calculara();
                    e.resultado();

            Console.WriteLine("Circulos: " + Circulo.getCantidad());
            Console.WriteLine("Rectángulos: " + Rectangulo.getCantidad());
            Console.WriteLine("Cuadrados: " + Cuadrado.getCantidad());
            Console.WriteLine("Elipses: " + Elipse.getCantidad());
            Console.WriteLine("Triángulos: " + Triangulo.getCantidad());
        }

        }
    }
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos.Services__funciones_
{
    public class Compra
    {
        //declaracion de las variables para la compra de los productos
        public float product1, product2, product3, product4, product5;
        public float tcompra;
        private int resp;

        //void pq sinceramente no se qeu valor pedirle para que regrese
        public void Pedir ()
        {

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            //preguntar los precios de los productos
            Console.WriteLine("Ingrese el precio del primer producto");
            product1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del segundo producto");
            product2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del tercer producto");
            product3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del cuarto producto");
            product4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del quinto producto");
            product5 = float.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------");
            Console.Clear();

            tcompra = product1 + product2 + product3 + product4 + product5;     //suma para el total de la compra SIN DESCUENTO, PRECIO LIMPIO      

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Tu total de compra fue de $" + tcompra);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            Operaciones operaciones = new();        //para que pueda usar las funciones de la clase operaciones

            if (tcompra >= 10000)           //tercer concepto
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                Console.WriteLine("Felicidades, puedes elegir entre tener 6 o 12 meses sin interes por tu compra mayor a 10000");
                Console.WriteLine("cuantos meses sin interes prefieres tener 6 o 12");
                resp = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                switch (resp)
                {
                    case 6:     //en el caso de 6 meses
                        tcompra = operaciones.SMesesSI(product1, product2, product3, product4, product5);
                        Console.WriteLine("Mensualmete pagarás " + tcompra + ":)");
                        Console.WriteLine("-----------------------------------------------------");
                        break;
                    case 12:        //en el caso de 12 meses
                        tcompra = operaciones.DMesesSI(product1, product2, product3, product4, product5);
                        Console.WriteLine("Mensualmete pagarás " + tcompra + ":)");
                        Console.WriteLine("-----------------------------------------------------");
                        break;

                }
            }
            else if (tcompra >= 8000)       //segundo concepto
            {
                tcompra = operaciones.TMesesSI(product1, product2, product3, product4, product5);
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                Console.WriteLine("Felicidades, tienes 3 meses sin interes por haber tenido una compra mayor a  a 8000");
                Console.WriteLine("Mensualmete pagarás " + tcompra + " :)");
                Console.WriteLine("----------------------------------------------------------------------------------------------");
            }

            else if (tcompra >= 5000)           //primer concepto
            {
                tcompra = operaciones.Descuento(product1, product2, product3, product4, product5);
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                Console.WriteLine("Felicidades, tienes un descuento del 10% por haber tenido una compra mayor a 5000");
                Console.WriteLine("Ahora pagarás " + tcompra + " :)");
                Console.WriteLine("----------------------------------------------------------------------------------------------");
            }
            else if (tcompra <= 4999)
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                Console.WriteLine("Tu compra fue de " + tcompra);
                Console.WriteLine("----------------------------------------------------------------------------------------------");
            }
        }
    }
}

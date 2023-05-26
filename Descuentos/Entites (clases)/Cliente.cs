using Descuentos.Services__funciones_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos.Entites__clases_
{
    public class Cliente
    {
        public string Nombre { get; set; }      //declaracion de las variables que se le pediran al cliente
        public string Correo { get;set; }
        public double telefono { get; set; }

        public void PedirDatos()            //pidiendo datos del cliente
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("- Ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("- Ingrese su numero de telefono: ");
            telefono = double.Parse(Console.ReadLine());
            Console.WriteLine("- Ingrese su correo electronico:");
            Correo = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");

            Console.Clear();

            Compra compra = new Compra();       //instanciamos la clasee compra ya que ahi es donde se van a pedir los precios
            compra.Pedir();                     //que funcione el pedir los precios
            //impresion de los datos del usuario al finalizar
            Console.WriteLine("============================================");      
            Console.WriteLine(this.Nombre);
            Console.WriteLine(this.telefono);
            Console.WriteLine(this.Correo);
            Console.WriteLine("============================================");
        }
    }
}

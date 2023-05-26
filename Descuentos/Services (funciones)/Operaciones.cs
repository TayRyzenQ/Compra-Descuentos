using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos.Services__funciones_
{
    public class Operaciones 
    {  
        //este es para el primer primer concepto, de que tenga descuento del 10%
        public float Descuento(float product1, float product2, float product3, float product4, float product5)  
        {
            float tcompra = product1 + product2 + product3 + product4 + product5;
            float descuento = tcompra * 0.10f;
            float tpagar = tcompra - descuento;
            return tpagar;
        }

        //este es para cuando tenga 3 meses sin intereses, es una funcion float entonces devuelve eso
        public float TMesesSI(float product1, float product2, float product3, float product4, float product5)
        {
            float tcompra = product1 + product2 + product3 + product4 + product5;
            tcompra = tcompra / 3;
            return tcompra;

        }
        //este es para cuando tenga 6 meses sin intereses, es una funcion float entonces devuelve eso
        public float SMesesSI(float product1, float product2, float product3, float product4, float product5)
        {
            float tcompra = product1 + product2 + product3 + product4 + product5;
            tcompra = tcompra / 6;
            return tcompra;
        }
        //este es para cuando tenga 12 meses sin intereses, es una funcion float entonces devuelve eso
        public float DMesesSI(float product1, float product2, float product3, float product4, float product5)
        {
            float tcompra = product1 + product2 + product3 + product4 + product5;
            tcompra = tcompra / 12;
            return tcompra;
        }

    }
}

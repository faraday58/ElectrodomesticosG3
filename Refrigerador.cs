using System;
using System.Threading;
namespace ElectrodomesticosG3
{
    class Refrigerador : LineaBlanca,IApagar,IEncender
    {
        public Refrigerador()
        {
            Marca = " Mabe ";            
            Console.WriteLine("{0} te da la bienvenida  , Temperatura del refrigerador es : 1 C",Marca);

        }

        public void Encender()
        {
            Console.WriteLine("Encendiendo luz interna");
        }

        void IApagar.Apagar()
        {
            Console.WriteLine(" Disminuyendo la temperatura interna");
            Console.WriteLine(" Apagando ");
            Thread.Sleep(2000);
            Console.WriteLine("Hasta luego");
        }
    }
}

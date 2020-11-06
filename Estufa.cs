using System;
using System.Threading;
namespace ElectrodomesticosG3
{
    class Estufa :LineaBlanca,IApagar,IEncender
    {

        public Estufa()
        {
            Marca = "G&E ";
            Console.WriteLine("Bienvenido {0}, todos los quemadores disponibles",Marca);               
        }

        public void Apagar()
        {
            Console.WriteLine("Disminuyendo flujo de gas");
            Thread.Sleep(2000);
            Console.WriteLine("Piloto apagado");
        }

        void IEncender.Encender()
        {
            Console.WriteLine(" Aumentando flujo de gas");
        }
    }
}

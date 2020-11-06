using System;

namespace ElectrodomesticosG3
{
    class Program
    {
        static void Main()
        {
            //Ocupando interfaz de manera implícita
            Estufa estufa = new Estufa();
            estufa.Apagar();
            IEncender encenderEstufa = (IEncender)estufa;
            encenderEstufa.Encender();


            //Colocando la interfaz de manera explícita
            IApagar apagarRefrigerador = new Refrigerador();
            apagarRefrigerador.Apagar();
            Refrigerador refrigerador = new Refrigerador();
            refrigerador.Encender();

        }
    }
}

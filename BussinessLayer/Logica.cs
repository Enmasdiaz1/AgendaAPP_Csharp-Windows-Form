using System;

namespace BussinessLayer
{
    public sealed class Logica
    {
        public static Logica Instancia { get; } = new Logica();

        public int ID { get; set; }
        public int ID2 { get; set; }
        public int INDEX{ get; set; }
        public int indice{ get; set; }


        private Logica()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteG2
{
    internal abstract class Transporte 
    {
        #region Atributos
        private string marca;
        private int kilometraje;
        public string combustible;
        internal int velocidad;
        internal int aumento;
        


        #endregion

        #region Propiedades
        public string Marca { get => marca; set => marca = value; }
        public virtual int Velocidad 
        { 
            get => velocidad;
            set
            {
                if (20 < value && value < 80)
                    velocidad = value;
                else
                    velocidad = 60;
            }
        }

        public virtual int Aumento
        {
            get => aumento;
            set
            {
                if (20 < value && value < 40)
                    aumento = value;
                else
                    aumento = 30;
            }
        }
        #endregion

        #region Metodos

        public void Encender()
        {
            int RMP = 5200;
            Console.WriteLine("Motor encendido");

        }

        public void LimpDisp()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
       
        public virtual void Acelerar()
        {
            Console.WriteLine("Vas muy lento, aumenta tu velocidad a {0}[km/h]", velocidad + aumento);
        }
        public virtual void Frenar()
        {
            Console.WriteLine("Vas muy rápido, disminuye tu velocidad a {0} [km/h]", velocidad - aumento);
        }
         


        




        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteG2
{
    internal class Automovil : Transporte
    {
        #region Propiedades
        public override int Aumento
        {
            get => base.Aumento;
            set
            {
                if (1 < value && value < 25)
                {
                    aumento = value;
                }

                else
                {
                    aumento = 5;
                }
            }
        }
        #endregion
        #region Constructor
        public Automovil()
        {
            Encender();
            Console.WriteLine("Motor del automovil encendido");
           
            Velocidad = 50;
            Aumento = 20;

            Console.WriteLine("Velocidad del automóvil: {0}[km/h]", Velocidad);
            
            if (Velocidad > 120)
            {
                Frenar();

            }
            else
            {
                Acelerar();
            }


        }
        #endregion

        #region Metodos 

        #endregion

    }
}

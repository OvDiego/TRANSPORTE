using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteG2
{
    internal class Tractor : Transporte
    {
        #region Propiedades
        public override int Velocidad 
        { get => base.Velocidad; 
          set
            {
                if (1 < value && value < 25)
                {
                    velocidad = value;
                }

                else
                {
                    velocidad = 10;
                }
            }
        }

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
        public Tractor()
        {
            Encender();
            Console.WriteLine("Motor del tractor encendido");
            
            Velocidad = 21;
            Aumento = 5;

            Console.WriteLine("Velocidad del tractor: {0}[km/h]", Velocidad);
            
            if (Velocidad > 20)
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

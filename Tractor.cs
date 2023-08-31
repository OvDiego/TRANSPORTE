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
        #endregion
        public Tractor()
        {
            Encender();
            
            LimpDisp();
            Velocidad = 15;
            Console.WriteLine("Velocidad: {0}", Velocidad);
            LimpDisp();
            if (Velocidad > 20)
            {
                Frenar();

            }
            else if (Velocidad < 5)
            {
                Acelerar();
            }
            else
            {
                LimpDisp();
            }
            


        }
        #region Metodos 

        #endregion
    }
}

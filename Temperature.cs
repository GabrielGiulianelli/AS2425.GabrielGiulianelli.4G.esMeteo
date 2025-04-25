using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2425.GabrielGiulianelli._4G.esMeteo
{
    internal class Temperature
    {
        List<Temperatura> temperature = new List<Temperatura>();

        public void IsExpired()
        {
            foreach (var t in temperature)
            {

            }
        }
        
        public List<Temperatura> ViewTemperature()
        {

            foreach (var t in temperature)
            {
                if (t.Descrizione == null)
                {
                    t.Renew();
                }
                else
                {
                    if (t.IsExpired())
                    {
                        t.Renew();
                    }
                }



            }
            return temperature;
        }

        public virtual void AddTemperature(Temperatura t)
        {
            temperature.Add(t);
        }

    }
}

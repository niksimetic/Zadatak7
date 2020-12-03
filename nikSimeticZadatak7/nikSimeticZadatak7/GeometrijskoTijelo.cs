using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticZadatak7
{
    class GeometrijskoTijelo
    {
        double volumen;
        double oplosje;
        public static int brojactijela;

        public double Volumen { get => volumen; set => volumen = value; }
        public double Oplosje { get => oplosje; set => oplosje = value; }

        public GeometrijskoTijelo()
        {
            brojactijela++;
        }
    }
}

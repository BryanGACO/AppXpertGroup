using System;
using System.Collections.Generic;
using System.Text;

namespace CubeSummationApp.Application.Entities
{
    public class Query
    {
        public string Tipo { get; set; }
        public Coordinate CoordenadaInicial { get; set; }
        public Coordinate CoordenadaFinal { get; set; }
    }
}

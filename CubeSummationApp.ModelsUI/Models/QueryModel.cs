using System;
using System.Collections.Generic;
using System.Text;

namespace CubeSummationApp.ModelsUI.Models
{
    public class QueryModel
    {
        public string Tipo { get; set; }
        public CoordinateModel CoordenadaInicial { get; set; }
        public CoordinateModel CoordenadaFinal { get; set; }
    }
}

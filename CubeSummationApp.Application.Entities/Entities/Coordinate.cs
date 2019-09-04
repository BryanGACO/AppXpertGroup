using System;
using System.Collections.Generic;
using System.Text;

namespace CubeSummationApp.Application.Entities
{
    public class Coordinate
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }        
        public int Value { get; set; }
        public int CubeId { get; set; }
    }
}

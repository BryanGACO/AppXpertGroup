using System.Collections.Generic;

namespace CubeSummationApp.Application.Entities
{
    public class Cube
    {
        private int _dimension;
        private int[,,] _matrizDatos;

        public int Id { get; set; }

        public int Dimension {
            get
            {
                return _dimension;
            }

            set
            {
                _dimension = value;
                GenerarMatrizDatos();
            }
        }

        public int Operaciones{ get; set; }

        public List<Query> Queries { get; set; }

        private void GenerarMatrizDatos()
        {
            _matrizDatos = new int[Dimension, Dimension, Dimension];            
        }

        public int GetQuery(Coordinate initialCoordinate, Coordinate finalCoordinate)
        {
            int resultado = 0;

            for (int x = initialCoordinate.X - 1  ; x <= finalCoordinate.X - 1; x++)
            {
                for (int y = initialCoordinate.Y - 1; y <= finalCoordinate.Y - 1; y++)
                {
                    for (int z = initialCoordinate.Z - 1; z <= finalCoordinate.Z - 1; z++)
                    {
                        resultado = resultado + _matrizDatos[x, y, z];
                    }
                }
            }
            return resultado;
        }

        public void UpdateCoordinate(Coordinate coordinate)
        {
            _matrizDatos[coordinate.X - 1, coordinate.Y - 1, coordinate.Z - 1] = coordinate.Value;
        }
    }
}

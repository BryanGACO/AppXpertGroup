using System;
using System.Collections.Generic;
using System.Text;

namespace CubeSummationApp.DataAccess.Contracts.Entities
{
    public class CubeEntity
    {
        public int Id { get; set; }
        public int Dimension { get; set; }

        public int UserId { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual ICollection<CoordinateEntity> Coordinates { get; set; }
    }
}

using System.Collections.Generic;

namespace CubeSummationApp.ModelsUI.Models
{
    public class CubeModel
    {
        public int Id { get; set; }
        public int Dimension { get; set; }
        public int Operaciones { get; set; }
        public List<QueryModel> Queries { get; set; }
    }
}

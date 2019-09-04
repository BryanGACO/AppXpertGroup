using System;
using System.Collections.Generic;

namespace CubeSummationApp.DataAccess.Contracts.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<UserEntity> Users { get; set; }
    }
}

using CubeSummationApp.Application.Entities;
using CubeSummationApp.DataAccess.Contracts.Entities;


namespace CubeSummationApp.DataAccess.Contracts.Mappers
{
    public static class UserMapper
    {
        public static UserEntity Map(User dto)
        {
            return new UserEntity()
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }

        public static User Map(UserEntity entity)
        {
            return new User()
            {                
                Id = entity.Id,
                Name = entity.Name                
            };
        }
    }
}

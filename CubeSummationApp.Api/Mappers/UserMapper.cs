using CubeSummationApp.Application.Entities;
using CubeSummationApp.ModelsUI.Models;

namespace CubeSummationApp.Api.Mappers
{
    public static class UserMapper
    {
        public static User Map(UserModel model)
        {
            return new User()
            {
                Id = model.Id,
                Name = model.Name,
                
            };
        }

        public static UserModel Map(User dto)
        {
            return new UserModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                
            };
        }
    }
}

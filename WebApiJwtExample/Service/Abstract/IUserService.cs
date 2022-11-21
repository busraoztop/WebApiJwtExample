using WebApiJwtExample.DTO;
using WebApiJwtExample.Model;

namespace WebApiJwtExample.Service.Abstract
{
    public interface IUserService
    {
        bool Any(UserDto user);

        bool Save(User user);
    }
}

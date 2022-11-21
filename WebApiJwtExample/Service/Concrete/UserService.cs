using WebApiJwtExample.Data;
using WebApiJwtExample.DTO;
using WebApiJwtExample.Model;
using WebApiJwtExample.Service.Abstract;

namespace WebApiJwtExample.Service.Concrete
{
    public class UserService : IUserService
    {
        private readonly DatabaseContext _db;

        public UserService(DatabaseContext db)
        {
            _db = db;
        }

        public bool Any(UserDto user)
        {
            return _db.Set<User>().Any(busra => busra.UserName == user.UserName && busra.Password == user.Password);
        }

        public bool Save(User user)
        {
            _db.Add(user);
            _db.SaveChanges();
            return true;    
        }
    }
}

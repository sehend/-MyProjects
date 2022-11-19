using Core.Model;
using Data.Abstract;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class UserManager : IUserService
    {

        IUserDal _userdal;

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }

        public void Add(User user)
        {
            _userdal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userdal.Get(x => x.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userdal.GetClaims(user);
        }
    }
}

using Core.Model;
using Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IUserDal : IRepository<User>
    {
        List<OperationClaim> GetClaims(User user);



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSR.Entities;

namespace FSR.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByLogin(string login, string password);
    }
}

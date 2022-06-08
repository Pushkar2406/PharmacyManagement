using System.Collections.Generic;
using PharmacyManagement.Models;


namespace PharmacyManagement.Repository
{
    public interface IUserRepository
    {
        UserDetail Create(UserDetail user);
        IEnumerable<UserDetail> GetAll();
        UserDetail GetByEmail(string email);
        UserDetail GetById(int id);
    }
}
using System;
namespace UserTicketService.Tests
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            return null;
        }
    }

    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }

    public class User
    {
        public string Name
        {
            get;
            set;
        }
    }
}


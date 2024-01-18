using Domain.Entities;

namespace Domain.Adapters
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListUsers(int offset, int limit);
        Task<User?> GetUserByID(Guid userId);
        Task InsertUser(User user);
        Task DeleteUser(User user);
    }
}

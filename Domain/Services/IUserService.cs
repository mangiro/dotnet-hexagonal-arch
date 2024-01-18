using Domain.Entities;

namespace Domain.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers(int pageNumber, int pageSize);
        Task<User?> GetUser(Guid userId);
        Task CreateUser(User user);
        Task RemoveUser(Guid userId);
    }
}

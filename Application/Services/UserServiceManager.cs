using Domain.Adapters;
using Domain.Entities;
using Domain.Services;

namespace Application.Services
{
    public class UserServiceManager : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserServiceManager(IUserRepository userRepository) =>
            _userRepository = userRepository;

        public async Task<IEnumerable<User>> GetUsers(int pageNumber, int pageSize)
        {
            return await _userRepository.ListUsers(pageNumber, pageSize);
        }

        public async Task<User?> GetUser(Guid userId)
        {
            var user =  await _userRepository.GetUserByID(userId);

            return user;
        }

        public async Task CreateUser(User user)
        {
            await _userRepository.InsertUser(user);
        }

        public async Task RemoveUser(Guid userId)
        {
            var user =  await _userRepository.GetUserByID(userId);

            if (user is not null) {
                await _userRepository.DeleteUser(user);
            }
        }
    }
}

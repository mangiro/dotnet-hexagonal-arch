using Domain.Adapters;
using Domain.Entities;
using Infra.Database.PostgreSQL.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database.PostgreSQL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public async Task<IEnumerable<User>> ListUsers(int offset, int limit)
        {
            return await _context.Users
                .Skip((offset - 1) * limit)
                .Take(limit)
                .ToListAsync();
        }

        public async Task<User?> GetUserByID(Guid userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public async Task InsertUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}

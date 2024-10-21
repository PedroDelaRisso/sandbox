using GesFin.Domain.Models.User;
using GesFin.Shared.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace GesFin.Data.Repositories;

public class UserRepository(AppDbContext context) : IUserRepository
{
    private readonly AppDbContext _context = context;

    public async Task Add(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User> Get(long id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id)
            ?? throw new Exception("User not found");
        return user;
    }

    public async Task<List<User>> GetAll()
    {
        var users = await _context.Users.ToListAsync();
        return users;
    }

    public async Task Update(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(long id)
    {
        var user = await Get(id)
            ?? throw new Exception(CustomErrors.UserNotFound);
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(User user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}
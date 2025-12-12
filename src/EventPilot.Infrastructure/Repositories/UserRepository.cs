using EventPilot.Application.Interfaces.Repositories;
using EventPilot.Domain.Entities;
using EventPilot.Domain.Exceptions;
using EventPilot.Infrastructure.Context;

namespace EventPilot.Infrastructure.Repositories;

public class UserRepository(AppDbContext context): IUserRepository
{
    private readonly AppDbContext _context = context;
    
    
    public User? Create(User user)
    {
        var createdUser = _context.Users.Add(user);
        var isSuccess = _context.SaveChanges() > 0;
        if (!isSuccess)
            return null;
        
        return createdUser.Entity;
    }

    public User? GetByIdUser(long id)
    {
        throw new NotImplementedException();
    }

    public User Update(User user)
    {
        throw new NotImplementedException();
    }
}
using EventPilot.Domain.Entities;

namespace EventPilot.Application.Interfaces.Repositories;

public interface IUserRepository
{
    public User? Create(User user);

    public User? GetByIdUser(long id);
    
    public User Update(User user);
}
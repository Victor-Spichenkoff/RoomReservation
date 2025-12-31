using EventPilot.Application.Interfaces.Repositories;
using EventPilot.Domain.Entities;
using EventPilot.Domain.Enum;
using EventPilot.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EventPilot.Infrastructure.Repositories;

public class EventRepository(AppDbContext context) : IEventRepository
{
    private readonly AppDbContext _context = context;

    public async Task<Event?> GetByIdAsync(long id)
    {
        return await _context.Events.FindAsync(id);
    }

    public async Task<Event> CreateAsync(Event eventData)
    {
        var createdEntity = await _context.Events.AddAsync(eventData);
        await _context.SaveChangesAsync();
        return createdEntity.Entity;
    }

    public async Task<Event> UpdateAsync(Event eventData)
    {
        var updatedEntity = _context.Events.Update(eventData);
        await _context.SaveChangesAsync();
        
        return updatedEntity.Entity;
    }

    public bool DeleteByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    // public IQueryable<Event> Query()
    //  => _context.Events;
    //  // => _context.Events.AsNoTracking();

    public async Task<ICollection<Event>> Get(int page=0, int pageSize=10)
    => await _context.Events.Skip(page * pageSize)
        .Take(pageSize)
        .ToListAsync();
}
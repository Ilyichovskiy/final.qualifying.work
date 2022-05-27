using ContactCenter.Domain.Entities;
using ContactCenter.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ContactCenter.Domain.Repositories.EntityFramework;

public class ServiceItemsRepository : IServiceItemsRepository
{
    private readonly AppDbContext _context;

    public ServiceItemsRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public IQueryable<ServiceItem>? GetServiceItems()
    {
        return _context.ServiceItems;
    }

    public ServiceItem? GetServiceItem(Guid id)
    {
        if (_context.ServiceItems != null) return _context.ServiceItems.FirstOrDefault(x => x.Id == id);
        throw new Exception("Не удалось получить сервис по указанному идентификатору");
    }

    public void SaveServiceItem(ServiceItem entity)
    {
        _context.Entry(entity).State = entity.Id == default
            ? EntityState.Added
            : EntityState.Modified;

        _context.SaveChanges();
    }

    public void DeleteServiceItem(Guid id)
    {
        _context.ServiceItems?.Remove(new ServiceItem
        {
            Id = id
        });
        _context.SaveChanges();
    }
}
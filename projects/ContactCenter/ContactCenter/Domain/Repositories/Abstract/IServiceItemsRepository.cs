using ContactCenter.Domain.Entities;

namespace ContactCenter.Domain.Repositories.Abstract;

public interface IServiceItemsRepository
{
    /// <summary>
    /// Получить все доступные сервисы.
    /// </summary>
    /// <returns></returns>
    IQueryable<ServiceItem>? GetServiceItems();

    /// <summary>
    /// Получить сервис по идентификатору.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    ServiceItem? GetServiceItem(Guid id);

    /// <summary>
    /// Сохранить сервис или сохранить изменения.
    /// </summary>
    /// <param name="entity"></param>
    void SaveServiceItem(ServiceItem entity);

    /// <summary>
    /// Удалить сервис.
    /// </summary>
    /// <param name="id"></param>
    void DeleteServiceItem(Guid id);
}
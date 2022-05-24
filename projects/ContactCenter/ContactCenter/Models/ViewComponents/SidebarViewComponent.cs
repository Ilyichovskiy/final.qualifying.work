using ContactCenter.Domain;
using Microsoft.AspNetCore.Mvc;

namespace c;

public class SidebarViewComponent : ViewComponent
{
    private readonly DataManager _dataManager;

    public SidebarViewComponent(DataManager dataManager)
    {
        _dataManager = dataManager;
    }

    public Task<IViewComponentResult> InvokeAsync()
    {
        return Task.FromResult((IViewComponentResult) View("Default", _dataManager.ServiceItemsRepository.GetServiceItems()));
    }
}
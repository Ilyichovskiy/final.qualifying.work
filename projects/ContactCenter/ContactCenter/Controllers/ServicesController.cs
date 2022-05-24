using ContactCenter.Domain;
using ContactCenter.Service;
using Microsoft.AspNetCore.Mvc;

namespace ContactCenter.Controllers;

public class ServicesController : Controller
{
    private readonly DataManager _dataManager;
    private readonly ISmsService _smsService;

    public ServicesController(DataManager dataManager, ISmsService smsService)
    {
        _dataManager = dataManager;
        _smsService = smsService;
    }

    public IActionResult Index(Guid id)
    {
        if (id != default)
        {
            return View("Show", _dataManager.ServiceItemsRepository.GetServiceItem(id));
        }

        ViewBag.TextField = _dataManager.TextFieldsRepository.GetTextField("PageServices") ?? throw new InvalidOperationException();
        return View(_dataManager.ServiceItemsRepository.GetServiceItems());
    }

    public IActionResult Call()
    {
        
        return View();
    }

    public IActionResult Send()
    {
        _smsService.Send("model");
        return View();
    }
}
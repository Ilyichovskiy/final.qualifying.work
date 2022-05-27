using ContactCenter.Domain;
using ContactCenter.Service;
using Microsoft.AspNetCore.Mvc;

namespace ContactCenter.Controllers;

public class ServicesController : Controller
{
    private readonly DataManager _dataManager;
    private readonly ISmsService _smsService;
    private readonly ICallService _callService;

    public ServicesController(DataManager dataManager, ISmsService smsService, ICallService callService)
    {
        _dataManager = dataManager;
        _smsService = smsService;
        _callService = callService;
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

    [HttpGet]
    public IActionResult Call()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Call(string phoneNumber)
    {
        _callService.Call(phoneNumber);
        return View();
    }

    [HttpGet]
    public IActionResult Send()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Send(string phoneNumber, string textMessage)
    {
        var result = _smsService.Send(textMessage);
        ViewBag.Message = result
            ? $"Сообщение по номеру: {phoneNumber} успешно отправлено!"
            : $"Сообщение по номеру: {phoneNumber} не удалось отправить!";
        
        return View();
    }
    
    [HttpGet]
    public IActionResult Statistics()
    {
        return View();
    }
}
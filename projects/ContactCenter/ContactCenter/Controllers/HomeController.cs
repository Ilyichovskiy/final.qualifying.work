using ContactCenter.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ContactCenter.Controllers;

public class HomeController : Controller
{
    private readonly DataManager _dataManager;
    public HomeController(DataManager dataManager)
    {
        _dataManager = dataManager;
    }
    
    public IActionResult Index()
    {
        return View(_dataManager.TextFieldsRepository.GetTextField("PageIndex"));
    }
    
    public IActionResult Contacts()
    {
        return View(_dataManager.TextFieldsRepository.GetTextField("PageContacts"));
    }
}
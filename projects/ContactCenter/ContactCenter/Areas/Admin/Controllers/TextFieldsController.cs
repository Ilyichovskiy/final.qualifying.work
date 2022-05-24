using ContactCenter.Domain;
using ContactCenter.Domain.Entities;
using ContactCenter.Service;
using Microsoft.AspNetCore.Mvc;

namespace ContactCenter.Areas.Admin.Controllers;

[Area("Admin")]
public class TextFieldsController : Controller
{
    private readonly DataManager _dataManager;
    public TextFieldsController(DataManager dataManager)
    {
        _dataManager = dataManager;
    }

    public IActionResult Edit(string codeWord)
    {
        var entity = _dataManager.TextFieldsRepository.GetTextField(codeWord);
        return View(entity);
    }

    [HttpPost]
    public IActionResult Edit(TextField model)
    {
        if (ModelState.IsValid)
        {
            _dataManager.TextFieldsRepository.SaveTextField(model);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
        return View(model);
    }
}
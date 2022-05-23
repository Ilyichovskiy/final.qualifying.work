using ContactCenter.Domain.Repositories.Abstract;

namespace ContactCenter.Domain;

public class DataManager
{
    private readonly ITextFieldsRepository _textFieldsRepository;
    private readonly IServiceItemsRepository _serviceItemsRepository;

    public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository)
    {
        _textFieldsRepository = textFieldsRepository;
        _serviceItemsRepository = serviceItemsRepository;
    }
}
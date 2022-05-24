using ContactCenter.Domain.Repositories.Abstract;

namespace ContactCenter.Domain;

public class DataManager
{
    public ITextFieldsRepository TextFieldsRepository;
    public IServiceItemsRepository ServiceItemsRepository;

    public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository)
    {
        TextFieldsRepository = textFieldsRepository;
        ServiceItemsRepository = serviceItemsRepository;
    }
}
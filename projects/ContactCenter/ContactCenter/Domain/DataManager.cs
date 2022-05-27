using ContactCenter.Domain.Repositories.Abstract;

namespace ContactCenter.Domain;

public class DataManager
{
    public readonly ITextFieldsRepository TextFieldsRepository;
    public readonly IServiceItemsRepository ServiceItemsRepository;

    public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository)
    {
        TextFieldsRepository = textFieldsRepository;
        ServiceItemsRepository = serviceItemsRepository;
    }
}
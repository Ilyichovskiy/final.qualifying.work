using ContactCenter.Domain.Entities;

namespace ContactCenter.Domain.Repositories.Abstract;

public interface ITextFieldsRepository
{
    /// <summary>
    /// Получить все текстовые поля.
    /// </summary>
    /// <returns></returns>
    IQueryable<TextField>? GetTextFields();

    /// <summary>
    /// Выбрать поле по идентификатору.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    TextField? GetTextField(Guid id);

    /// <summary>
    /// Выбрать поле по ключевому слову.
    /// </summary>
    /// <param name="codeWord"></param>
    /// <returns></returns>
    TextField? GetTextField(string codeWord);

    /// <summary>
    /// Сохранить текстовое поле или сохранить изменения.
    /// </summary>
    /// <param name="entity"></param>
    void SaveTextField(TextField entity);

    /// <summary>
    /// Удалить текстовое поле.
    /// </summary>
    /// <param name="id"></param>
    void DeleteTextField(Guid id);
}
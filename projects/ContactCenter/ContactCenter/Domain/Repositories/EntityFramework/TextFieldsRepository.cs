using ContactCenter.Domain.Entities;
using ContactCenter.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ContactCenter.Domain.Repositories.EntityFramework;

public class TextFieldsRepository : ITextFieldsRepository
{
    private readonly AppDbContext _context;

    public TextFieldsRepository(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<TextField>? GetTextFields()
    {
        return _context.TextFields;
    }

    public TextField? GetTextField(Guid id)
    {
        if (_context.TextFields != null) return _context.TextFields.FirstOrDefault(x => x.Id == id);
        throw new Exception("Не удалось получить текстовое поле по указанному идентификатору");
    }

    public TextField? GetTextField(string codeWord)
    {
        if (_context.TextFields != null) return _context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        throw new Exception("Не удалось получить текстовое поле по указанному ключевому слову");
    }

    public void SaveTextField(TextField entity)
    {
        _context.Entry(entity).State = entity.Id == default
            ? EntityState.Added
            : EntityState.Modified;

        _context.SaveChanges();
    }

    public void DeleteTextField(Guid id)
    {
        _context.TextFields?.Remove(new TextField
        {
            Id = id
        });
        _context.SaveChanges();
    }
}
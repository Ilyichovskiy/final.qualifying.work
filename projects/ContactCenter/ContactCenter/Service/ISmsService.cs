namespace ContactCenter.Service;

public interface ISmsService
{
    public bool Send(string message);
}
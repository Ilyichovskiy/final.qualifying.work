using Nancy;

namespace WebApplicationOne;

public sealed class CurrentDateTimeModule : NancyModule
{
    public CurrentDateTimeModule()
    {
        Get("/", _ => DateTime.UtcNow);
    }
}
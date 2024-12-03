namespace InnoTrack.WebApi.Services.Exceptions;

public abstract class NotFoundException : Exception
{
    protected internal NotFoundException(string message) : base(message)
    {
    }
}
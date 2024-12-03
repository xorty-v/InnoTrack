namespace InnoTrack.WebApi.Services.Exceptions;

public sealed class InnovationNotFoundException : NotFoundException
{
    internal InnovationNotFoundException() : base("Innovation not found")
    {
    }
}
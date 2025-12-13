namespace EventPilot.Domain.Exceptions;

public class ApiException : DomainException 
{
    public int StatusCode;

    public ApiException(
        string message,
        int statusCode = 400
    ) : base(message)
    {
        StatusCode = statusCode;
    }
}
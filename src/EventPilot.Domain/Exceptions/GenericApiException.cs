namespace EventPilot.Domain.Exceptions;

public class GenericApiException(
    string message,
    int statusCode = 400
    ): Exception
{
    public new string Message = message;
    public int StatusCode = statusCode;

}
using System.Net;
using System.Text.Json;
using EventPilot.Domain.Exceptions;

namespace EventPilot.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ApiException ex)
        {
            await HandleDomainExceptionAsync(context, ex);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleDomainExceptionAsync(HttpContext context, DomainException exception)
    {
        context.Response.ContentType = "application/json";

        // Parse error -> status
        var statusCode = exception switch
        {
            NotFoundException => 404,
            BusinessException => 400,
            _ => 400
        };
        
        var message = exception.Message;

        var response = new
        {
            status = statusCode,
            error = message
        };

        context.Response.StatusCode = statusCode;

        return context.Response.WriteAsync(
            JsonSerializer.Serialize(response));
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        Console.Error.WriteLine(exception);
        Console.WriteLine("[ ERROR ] Server error");
        context.Response.ContentType = "application/json";

        var statusCode = HttpStatusCode.InternalServerError;
        var message = "Unexpected error";

        // Aqui depois vamos melhorar
        var response = new
        {
            status = (int)statusCode,
            error = message
        };

        context.Response.StatusCode = (int)statusCode;

        return context.Response.WriteAsync(
            JsonSerializer.Serialize(response)
        );
    }
}
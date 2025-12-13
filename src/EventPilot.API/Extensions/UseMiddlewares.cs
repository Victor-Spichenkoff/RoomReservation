using EventPilot.Middlewares;

namespace EventPilot.Extensions;

public static class UseMiddlewaresExtension
{
    public static IApplicationBuilder UseMiddlewares(this IApplicationBuilder app)
    {
        // always on top
        app.UseMiddleware<ExceptionHandlingMiddleware>();
        return app;
    }
}
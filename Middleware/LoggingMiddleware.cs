namespace UserManagementAPI.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Log request details
            var requestMethod = context.Request.Method;
            var requestPath = context.Request.Path;

            await _next(context);

            // Log response details
            var responseStatusCode = context.Response.StatusCode;

            Console.WriteLine($"Method: {requestMethod}, Path: {requestPath}, Status: {responseStatusCode}");
        }
    }
}

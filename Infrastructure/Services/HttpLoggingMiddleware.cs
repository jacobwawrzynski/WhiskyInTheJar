using Infrastructure.DataContext;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services
{
    public class HttpLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<HttpLoggingMiddleware> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HttpLoggingMiddleware(
            RequestDelegate next, 
            ILogger<HttpLoggingMiddleware> logger, 
            ApplicationDbContext dbContext)
        {
            _next = next;
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var originalRequest = context.Request;
            var originalResponse = context.Response;

            var requestBuffer = new MemoryStream();
            var responseBuffer = new MemoryStream();

            context.Request.Body = requestBuffer;
            context.Response.Body = responseBuffer;

            try
            {
                await originalRequest.Body.CopyToAsync(requestBuffer);
                requestBuffer.Position = 0;

                var requestBody = await new StreamReader(requestBuffer).ReadToEndAsync();
                responseBuffer.Position = 0;

                _logger.LogInformation($"Request: {originalRequest.Method} {originalRequest.Path} {requestBody}");

                var requestLog = new RequestLog
                {
                    Method = originalRequest.Method,
                    Path = originalRequest.Path,
                    Body = requestBody
                };

                _dbContext.Set<RequestLog>().Add(requestLog);
                await _dbContext.SaveChangesAsync();

                await _next(context);

                responseBuffer.Position = 0;
                await responseBuffer.CopyToAsync(originalResponse.Body);
                responseBuffer.Position = 0;

                var responseBody = await new StreamReader(responseBuffer).ReadToEndAsync();
                responseBuffer.Position = 0;

                _logger.LogInformation($"Response: {originalResponse.StatusCode} {responseBody}");

                var responseLog = new ResponseLog
                {
                    StatusCode = originalResponse.StatusCode,
                    Body = responseBody
                };

                _dbContext.Set<ResponseLog>().Add(responseLog);
                await _dbContext.SaveChangesAsync();
            }
            finally
            {
                context.Request.Body = originalRequest.Body;
                context.Response.Body = originalResponse.Body;
            }
        }
    }
}

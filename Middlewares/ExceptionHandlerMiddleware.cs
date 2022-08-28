using System.Net;

namespace ExceptionHandlingMiddlewares.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _request;

        public ExceptionHandlerMiddleware(RequestDelegate request)
        {
            _request = request;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
            
            try
            {
                await _request.Invoke(httpContext);
            }
            catch (Exception ex)
            {
                //İşlemler
               await httpContext.Response.WriteAsJsonAsync("Middleware HATA # " + ex.Message);
            }
        }
    }
}

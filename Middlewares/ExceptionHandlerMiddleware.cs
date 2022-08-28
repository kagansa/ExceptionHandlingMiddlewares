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
            try
            {
                await _request.Invoke(httpContext);
            }
            catch (Exception ex)
            {
                //İşlemler
                
            }
        }
    }
}

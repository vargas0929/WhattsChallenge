using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Whatts.Services.WebApi.Filters
{
    public class ApiKeyAuthAttribute : Attribute, IAsyncActionFilter
    {
        private const string ApiKeyHeaderName = "x-api-key";
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName, out var outApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            var configuration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = configuration.GetValue<string>("ApiKey");
            if (!apiKey.Equals(outApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            await next();

        }
    }
}

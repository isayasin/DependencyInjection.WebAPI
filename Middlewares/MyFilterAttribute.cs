using Microsoft.AspNetCore.Mvc.Filters;

namespace DependencyInjection.WebAPI.Middlewares;

public class MyFilterAttribute : Attribute, IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        // işlem bittiğinde
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        // işlem başladığında
    }
}

using Microsoft.AspNetCore.Mvc.Filters;

namespace StockControlSystem.Filters
{
    public class EmptyFilter : IActionFilter
    {
        public EmptyFilter()
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}

using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using UdemyAspNetCore.Models;

namespace UdemyAspNetCore.Filters
{
    public class ValidFirstName: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionary = context.ActionArguments.FirstOrDefault(X =>X.Key == "customer");
            var customer = dictionary.Value as Customer;

            base.OnActionExecuting(context);
        }
    }
}

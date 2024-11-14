using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace UdemyAspNetCore.Middlewares
{
    public class RequestEditingMiddleware
    {
        private RequestDelegate _requestDelegate;
        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context) {

            // ysk.com.tr/berkin
            if (context.Request.Path.ToString() == "/berkin") { 
                await context.Response.WriteAsync("Hoşgeldin Berkin");
            }else
                await _requestDelegate.Invoke(context);

        }
    }
}

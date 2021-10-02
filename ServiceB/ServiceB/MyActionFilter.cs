using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceB
{
    public class MyActionFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
           StringValues key;
            bool result = context.HttpContext.Request.Headers.TryGetValue("X-API-KEY", out key);
            if ((result == false) | key != "123")
            {
                context.Result = new ContentResult()
                {
                    Content = "API key is not valid."
                };
            }            
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
        }
    }
}

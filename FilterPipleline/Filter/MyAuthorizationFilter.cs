using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FilterPipleline.Filter
{
    public class MyAuthorizationFilter : IAuthorizationFilter
    {
        /// <summary>
        /// 第一个执行
        /// </summary>
        /// <param name="context"></param>
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //throw new NotImplementedException();
            //context.HttpContext.Response..LogDebug("权限过滤器");
        }
    }
}

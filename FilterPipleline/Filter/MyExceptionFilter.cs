using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterPipleline.Filter
{
    public class MyExceptionFilter : IExceptionFilter
    {
        /// <summary>
        /// 方法执行之后，只有方法执行异常才进入
        /// </summary>
        /// <param name="context"></param>
        public void OnException(ExceptionContext context)
        {
            //throw new NotImplementedException();
        }
    }
}

using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterPipleline.Filter
{
    public class MyResultFilter : IResultFilter
    {
        /// <summary>
        /// 结果执行之后，资源过滤器之前，倒数第二个过滤器
        /// </summary>
        /// <param name="context"></param>
        public void OnResultExecuted(ResultExecutedContext context)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// 异常过滤器或方法执行完成之后，结果执行之前
        /// </summary>
        /// <param name="context"></param>
        public void OnResultExecuting(ResultExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}

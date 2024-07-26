using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Re.Admin.Core;
using Re.Admin.Models;
using Re.Admin.MyExceptions;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Validation;

namespace Re.Admin.Filters
{
    public class AppGlobalExceptionFilter : IAsyncExceptionFilter
    {
        private readonly IFileLogger _fileLogger;

        public AppGlobalExceptionFilter(IFileLogger fileLogger)
        {
            _fileLogger = fileLogger;
        }

        public async Task OnExceptionAsync(ExceptionContext context)
        {
            if (context.ExceptionHandled) return;

            string errMsg = context.Exception.Message;
            context.Result = new ObjectResult(new AppResult(-1, errMsg));
            context.ExceptionHandled = true;

            AppBusinessLogFilter.WriteLog(context.HttpContext, context.Result);

            if (context.Exception is TipException || context.Exception is AbpValidationException
                || context.Exception is BusinessException) return;

            _fileLogger.Write(errMsg, exception: context.Exception);
        }
    }
}
﻿using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

using Re.Admin.Account;
using Re.Admin.CustomAttrs;
using Re.Admin.Models;

namespace Re.Admin.Middlewares
{
    public class PermissionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IAccountService _accountService;

        public PermissionMiddleware(RequestDelegate next, IAccountService accountService)
        {
            _next = next;
            _accountService = accountService;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var permission = context.GetEndpoint()?.Metadata?.GetMetadata<PermissionAttribute>();
            if (permission != null)
            {
                var user = await _accountService.GetUserInfoAsync();
                //超管放行
                if (user.IsSuperAdmin())
                {
                    goto NextStep;
                }
                else if (user.Auths == null || !user.Auths.Contains(permission.Str))
                {
                    await context.Response.WriteAsJsonAsync(new AppResult(-1, "权限不足，无法访问或操作"));
                    return;
                }
                else if(user.NickName != null && user.NickName.Contains("演示"))
                {
                    //含“演示”字样，并且非get，option操作拦截
                    var method = context.Request.Method.ToLower();
                    if(method != "get" && method != "option")
                    {
                        await context.Response.WriteAsJsonAsync(new AppResult(-1, "演示用户，无法访问或操作"));
                        return;
                    }
                }
            }
        NextStep:
            await _next(context);
        }
    }
}
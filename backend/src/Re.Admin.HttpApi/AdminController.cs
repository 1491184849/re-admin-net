using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Re.Admin;

[Authorize]
[ApiController]
public abstract class AdminController : AbpControllerBase
{
    protected AdminController()
    {
    }
}

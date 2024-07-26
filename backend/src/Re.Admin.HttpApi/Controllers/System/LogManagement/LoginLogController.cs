using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Re.Admin.CustomAttrs;
using Re.Admin.Filters;
using Re.Admin.System.LogManagement;
using Re.Admin.System.LogManagement.Dtos;

using Volo.Abp.Application.Dtos;

namespace Re.Admin.Controllers.System.LogManagement
{
    [Route("adm/login-log")]
    public class LoginLogController : AdminController
    {
        private readonly ILoginLogService _loginLogService;

        public LoginLogController(ILoginLogService loginLogService)
        {
            _loginLogService = loginLogService;
        }

        /// <summary>
        /// 删除登录日志
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpDelete("delete")]
        [AppResultFilter]
        [Permission("admin_system_loginlog_delete")]
        public Task<bool> DeleteLoginLogsAsync([FromBody] int[] ids) => _loginLogService.DeleteLoginLogsAsync(ids);

        /// <summary>
        /// 登录日志分页列表
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpGet("list")]
        [AppResultFilter]
        [Permission("admin_system_loginlog_list")]
        public Task<PagedResultDto<LoginLogListDto>> GetLoginLogListAsync([FromQuery] LoginLogQueryDto dto) => _loginLogService.GetLoginLogListAsync(dto);
    }
}
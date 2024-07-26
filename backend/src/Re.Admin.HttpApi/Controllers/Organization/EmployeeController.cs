using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Re.Admin.CustomAttrs;
using Re.Admin.Filters;
using Re.Admin.Models;
using Re.Admin.Organization;
using Re.Admin.Organization.Dtos;

namespace Re.Admin.Controllers.Organization
{
    [Route("adm/employee")]
    [AppResultFilter]
    public class EmployeeController : AdminController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// 新增员工
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("add")]
        [Permission("admin_system_employee_add")] public Task<bool> AddEmployeeAsync([FromBody] EmployeeDto dto) => _employeeService.AddEmployeeAsync(dto);

        /// <summary>
        /// 员工列表
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpGet("list")]
        [Permission("admin_system_employee_list")]
        public Task<PagedResultStruct<EmployeeListDto>> GetEmployeeListAsync([FromQuery] EmployeeQueryDto dto) => _employeeService.GetEmployeeListAsync(dto);

        /// <summary>
        /// 修改员工
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("update")]
        [Permission("admin_system_employee_update")]
        public Task<bool> UpdateEmployeeAsync([FromBody] EmployeeDto dto) => _employeeService.UpdateEmployeeAsync(dto);

        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id:guid}")]
        [Permission("admin_system_employee_delete")]
        public Task<bool> DeleteEmployeeAsync(Guid id) => _employeeService.DeleteEmployeeAsync(id);
    }
}
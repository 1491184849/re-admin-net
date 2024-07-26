using System;

using Re.Admin.Models;

namespace Re.Admin.Organization.Dtos
{
    public class EmployeeQueryDto : PageSearch
    {
        /// <summary>
        /// 姓名/手机号/工号
        /// </summary>
        public string? Keyword { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public Guid? DeptId { get; set; }
    }
}
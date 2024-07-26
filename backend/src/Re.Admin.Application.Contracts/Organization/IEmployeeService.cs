﻿using System;
using System.Threading.Tasks;

using Re.Admin.Models;
using Re.Admin.Organization.Dtos;

namespace Re.Admin.Organization
{
    public interface IEmployeeService
    {
        /// <summary>
        /// 新增员工
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<bool> AddEmployeeAsync(EmployeeDto dto);

        /// <summary>
        /// 员工树形列表
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<PagedResultStruct<EmployeeListDto>> GetEmployeeListAsync(EmployeeQueryDto dto);

        /// <summary>
        /// 修改员工
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<bool> UpdateEmployeeAsync(EmployeeDto dto);

        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteEmployeeAsync(Guid id);
    }
}
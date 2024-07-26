﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System;

using Re.Admin.Models;
using Re.Admin.System.Dtos;
using Microsoft.AspNetCore.Mvc;
using Re.Admin.CustomAttrs;
using Re.Admin.Filters;
using Re.Admin.Organization;
using Re.Admin.Organization.Dtos;

namespace Re.Admin.Controllers.Organization
{
    [Route("adm/dept")]
    public class DeptController : AdminController
    {
        private readonly IDeptService _deptService;

        public DeptController(IDeptService deptService)
        {
            _deptService = deptService;
        }

        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("add")]
        [AppResultFilter]
        [Permission("admin_system_dept_add")]
        public Task<bool> AddDeptAsync([FromBody] DeptDto dto) => _deptService.AddDeptAsync(dto);

        /// <summary>
        /// 部门树形列表
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpGet("list")]
        [AppResultFilter]
        [Permission("admin_system_dept_list")]
        public Task<List<DeptListDto>> GetDeptListAsync([FromQuery] DeptQueryDto dto) => _deptService.GetDeptListAsync(dto);

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("update")]
        [AppResultFilter]
        [Permission("admin_system_dept_update")]
        public Task<bool> UpdateDeptAsync([FromBody] DeptDto dto) => _deptService.UpdateDeptAsync(dto);

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id:guid}")]
        [AppResultFilter]
        [Permission("admin_system_dept_delete")]
        public Task<bool> DeleteDeptAsync(Guid id) => _deptService.DeleteDeptAsync(id);

        /// <summary>
        /// 获取部门组成的选项树
        /// </summary>
        /// <returns></returns>
        [HttpGet("options")]
        [AppResultFilter]
        public Task<List<AppOption>> GetDeptOptionsAsync() => _deptService.GetDeptOptionsAsync();
    }
}
﻿using System;
using Re.Admin.Models;

namespace Re.Admin.Organization.Dtos
{
    public class PositionQueryDto : PageSearch
    {
        /// <summary>
        /// 职位编号
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 职级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 状态：1正常2停用
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 职位分组
        /// </summary>
        public Guid? GroupId { get; set; }
    }
}
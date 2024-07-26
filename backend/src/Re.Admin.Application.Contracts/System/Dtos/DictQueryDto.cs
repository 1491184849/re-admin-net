﻿using Re.Admin.Models;

namespace Re.Admin.System.Dtos
{
    public class DictQueryDto : PageSearch
    {
        /// <summary>
        /// 字典键
        /// </summary>
        public string? Key { get; set; }

        /// <summary>
        /// 显示文本
        /// </summary>
        public string? Label { get; set; }

        /// <summary>
        /// 组名
        /// </summary>
        public string? GroupName { get; set; }
    }
}
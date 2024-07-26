﻿namespace Re.Admin.Models
{
    public class AppOption
    {
        /// <summary>
        /// 显示文本
        /// </summary>
        public string? Label { get; set; }

        /// <summary>
        /// 实际值
        /// </summary>
        public string? Value { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        public object? Extra { get; set; }
    }
}
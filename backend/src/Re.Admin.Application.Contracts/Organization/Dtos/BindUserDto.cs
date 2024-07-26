using System;
using System.ComponentModel.DataAnnotations;

namespace Re.Admin.Organization.Dtos
{
    public class BindUserDto
    {
        /// <summary>
        /// 员工ID
        /// </summary>
        [Required]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Required]
        public Guid UserId { get; set; }
    }
}
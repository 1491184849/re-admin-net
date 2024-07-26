using Re.Admin.Models;

namespace Re.Admin.System.Dtos
{
    public class RoleQueryDto : PageSearch
    {
        /// <summary>
        /// 角色名
        /// </summary>
        public string? RoleName { get; set; }
    }
}
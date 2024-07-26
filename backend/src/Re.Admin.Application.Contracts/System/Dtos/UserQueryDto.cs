using Re.Admin.Models;

namespace Re.Admin.System.Dtos
{
    public class UserQueryDto : PageSearch
    {
        public string? UserName { get; set; }
    }
}
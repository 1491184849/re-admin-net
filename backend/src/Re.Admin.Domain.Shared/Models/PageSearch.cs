using Re.Admin.Core;

namespace Re.Admin.Models
{
    public class PageSearch : IPage
    {
        public int Size { get; set; }
        public int Page { get; set; }
    }
}
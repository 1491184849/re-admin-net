using System;
using System.Collections.Generic;
using System.Text;

namespace Re.Admin.Models
{
    public interface IAppResult
    {
        int Code { get; set; }
        string? Message { get; set; }

        bool IsOk();
    }
}
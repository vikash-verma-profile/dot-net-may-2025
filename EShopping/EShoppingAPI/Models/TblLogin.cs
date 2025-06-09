using System;
using System.Collections.Generic;

namespace EShoppingAPI.Models;

public partial class TblLogin
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public int? IsActive { get; set; }
}

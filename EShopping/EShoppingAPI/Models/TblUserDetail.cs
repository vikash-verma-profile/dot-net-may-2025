using System;
using System.Collections.Generic;

namespace EShoppingAPI.Models;

public partial class TblUserDetail
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? Gender { get; set; }
}

using System;
using System.Collections.Generic;

namespace EShoppingAPI.Models;

public partial class TblProduct
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public string? Size { get; set; }

    public string? Color { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? Discount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}

using System;
using System.Collections.Generic;

namespace EShoppingAPI.Models;

public partial class TblOrder
{
    public int Id { get; set; }

    public string? OrderNumber { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? Discount { get; set; }

    public int? UserId { get; set; }

    public int? OrderStatus { get; set; }

    public int? IsPayment { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}

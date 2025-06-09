using System;
using System.Collections.Generic;

namespace EShoppingAPI.Models;

public partial class TblOrderDetail
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public int? OrderId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdatedBy { get; set; }
}

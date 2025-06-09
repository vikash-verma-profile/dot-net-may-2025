using System;
using System.Collections.Generic;

namespace EShoppingAPI.Models;

public partial class TblPayment
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? PaymentMode { get; set; }

    public decimal? Amount { get; set; }

    public string? TransactionId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}

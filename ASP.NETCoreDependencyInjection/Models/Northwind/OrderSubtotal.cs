using System;
using System.Collections.Generic;

namespace ASP.NETCoreDependencyInjection.Models.Northwind;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}

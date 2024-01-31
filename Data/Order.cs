using System;
using System.Collections.Generic;

namespace AppWeb.Data;

public partial class Order
{
    public int Id { get; set; }

    public string? Country { get; set; }

    public double? Price { get; set; }

    public int? OrderQuantity { get; set; }
}

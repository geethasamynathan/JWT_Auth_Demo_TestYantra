using System;
using System.Collections.Generic;

namespace JWT_Auth_Demo.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int? CategoryId { get; set; }

    public decimal? Price { get; set; }
}

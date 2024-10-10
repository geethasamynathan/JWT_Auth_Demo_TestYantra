using System;
using System.Collections.Generic;

namespace JWT_Auth_Demo.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;
}

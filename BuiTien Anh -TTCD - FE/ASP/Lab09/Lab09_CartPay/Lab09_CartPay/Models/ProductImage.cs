using System;
using System.Collections.Generic;

namespace Lab09_CartPay.Models;

public partial class ProductImage
{
    public int Id { get; set; }

    public int? Pid { get; set; }

    public string? Image { get; set; }
}

using System;
using System.Collections.Generic;

namespace Lab08_1.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public float Price { get; set; }

    public int OrdersId { get; set; }

    public virtual Order Orders { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Lab08_1.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Image { get; set; } = null!;

    public float Price { get; set; }

    public float SalePrice { get; set; }

    public byte Status { get; set; }

    public string Description { get; set; } = null!;

    public int CategoryId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}

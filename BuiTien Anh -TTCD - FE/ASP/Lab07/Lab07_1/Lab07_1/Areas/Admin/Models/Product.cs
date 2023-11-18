using System;
using System.Collections.Generic;

namespace Lab07_1.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public double SalePrice { get; set; }

    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;
}

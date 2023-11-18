using System;
using System.Collections.Generic;

namespace Lab08_1.Models;

public partial class Blog
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte Status { get; set; }

    public int ViewCount { get; set; }

    public DateTime CreatedDate { get; set; }

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;
}

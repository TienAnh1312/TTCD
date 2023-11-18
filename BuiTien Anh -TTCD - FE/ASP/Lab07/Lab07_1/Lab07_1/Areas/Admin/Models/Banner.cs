using System;
using System.Collections.Generic;

namespace Lab07_1.Models;

public partial class Banner
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte Status { get; set; }

    public int Prioty { get; set; }

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;
}

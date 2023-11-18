using System;
using System.Collections.Generic;

namespace Lab08_1.Models;

public partial class Banner
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int Prioty { get; set; }

    public DateTime CreatedDate { get; set; }

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Lab08_1.Models;

public partial class Account
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Avatar { get; set; } = null!;

    public string Password { get; set; } = null!;
}

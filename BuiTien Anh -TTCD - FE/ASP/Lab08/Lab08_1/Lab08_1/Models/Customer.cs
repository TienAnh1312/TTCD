using System;
using System.Collections.Generic;

namespace Lab08_1.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Avatar { get; set; } = null!;

    public DateTime Birthday { get; set; }

    public string Gender { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Facebook { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

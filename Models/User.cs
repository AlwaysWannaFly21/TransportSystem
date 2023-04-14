using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public byte[]? PasswordHash { get; set; }

    public byte[]? PasswordSalt { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<RegistrationInfo> RegistrationInfos { get; } = new List<RegistrationInfo>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<TicketPurchase> TicketPurchases { get; } = new List<TicketPurchase>();

    public virtual ICollection<TransportUnit> TransportUnits { get; } = new List<TransportUnit>();
}

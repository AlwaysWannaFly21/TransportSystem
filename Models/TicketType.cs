using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class TicketType
{
    public int TicketTypeId { get; set; }

    public string TicketTypeName { get; set; } = null!;

    public decimal TicketPrice { get; set; }

    public virtual ICollection<TicketPurchase> TicketPurchases { get; } = new List<TicketPurchase>();
}

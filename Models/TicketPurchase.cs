using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class TicketPurchase
{
    public int TicketPurchaseId { get; set; }

    public int? UserId { get; set; }

    public int? BusId { get; set; }

    public int? TicketTypeId { get; set; }

    public DateTime? PurchaseTime { get; set; }

    public virtual TransportUnit? Bus { get; set; }

    public virtual TicketType? TicketType { get; set; }

    public virtual User? User { get; set; }
}

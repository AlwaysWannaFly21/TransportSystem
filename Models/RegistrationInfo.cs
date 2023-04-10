using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class RegistrationInfo
{
    public int RegistrationInfoId { get; set; }

    public DateTime ReadingTime { get; set; }

    public int UserId { get; set; }

    public int TransportUnitId { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public virtual TransportUnit TransportUnit { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

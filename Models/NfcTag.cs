using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class NfcTag
{
    public int TagId { get; set; }

    public int? TransportUnitId { get; set; }

    public virtual TransportUnit? TransportUnit { get; set; }
}

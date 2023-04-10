using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class TransportUnit
{
    public int TransportUnitId { get; set; }

    public int? RouteNumber { get; set; }

    public int? Capacity { get; set; }

    public int? DriverId { get; set; }

    public virtual User? Driver { get; set; }

    public virtual ICollection<NfcTag> NfcTags { get; } = new List<NfcTag>();

    public virtual ICollection<RegistrationInfo> RegistrationInfos { get; } = new List<RegistrationInfo>();

    public virtual ICollection<Sensor> Sensors { get; } = new List<Sensor>();

    public virtual ICollection<TicketPurchase> TicketPurchases { get; } = new List<TicketPurchase>();

    public virtual ICollection<Timetable> Timetables { get; } = new List<Timetable>();
}

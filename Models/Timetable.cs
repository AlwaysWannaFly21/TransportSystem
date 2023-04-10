using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class Timetable
{
    public int TimetableId { get; set; }

    public int TransportUnitId { get; set; }

    public int StationId { get; set; }

    public TimeSpan ArrivalTime { get; set; }

    public virtual Station Station { get; set; } = null!;

    public virtual TransportUnit TransportUnit { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class Station
{
    public int StationId { get; set; }

    public string StationName { get; set; } = null!;

    public double Longitude { get; set; }

    public double Latitude { get; set; }

    public virtual ICollection<Timetable> Timetables { get; } = new List<Timetable>();
}

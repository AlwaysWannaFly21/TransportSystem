using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class RouteStation
{
    public int RouteStationId { get; set; }

    public int RouteId { get; set; }

    public int StationId { get; set; }

    public virtual Route Route { get; set; } = null!;

    public virtual Station Station { get; set; } = null!;
}

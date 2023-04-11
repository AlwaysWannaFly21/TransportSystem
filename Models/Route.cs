using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class Route
{
    public int RouteId { get; set; }

    public string? RouteName { get; set; }

    public virtual ICollection<RouteStation> RouteStations { get; } = new List<RouteStation>();

    public virtual ICollection<TransportUnit> TransportUnits { get; } = new List<TransportUnit>();
}

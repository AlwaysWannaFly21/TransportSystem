using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class Sensor
{
    public int SensorId { get; set; }

    public int? TransportUnitId { get; set; }

    public virtual ICollection<SensorInfo> SensorInfos { get; } = new List<SensorInfo>();

    public virtual TransportUnit? TransportUnit { get; set; }
}

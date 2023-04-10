using System;
using System.Collections.Generic;

namespace TransportSystem.Models;

public partial class SensorInfo
{
    public int Id { get; set; }

    public int? IrTransmittersId { get; set; }

    public DateTime ReadingTime { get; set; }

    public int? PassengerCount { get; set; }

    public virtual Sensor? IrTransmitters { get; set; }
}

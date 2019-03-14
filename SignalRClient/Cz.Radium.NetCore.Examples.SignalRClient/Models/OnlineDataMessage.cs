using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Radium.NetCore.Examples.SignalRClient.Models
{
    class OnlineDataMessage
    {
        public long ObjectId { get; set; }

        public int? Azimuth{get;set;}

        public double? Speed { get; set; }

        public GpsPoint Position{get;set;}

        public long PositionId { get; set; }

        public bool IsEngineOn { get; set; }

        public DateTime Time { get; set; }
    }
}

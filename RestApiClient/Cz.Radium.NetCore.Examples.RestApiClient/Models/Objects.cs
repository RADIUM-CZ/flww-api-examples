using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Radium.NetCore.Examples.RestApiClient.Models
{
    public class Objects
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Identification { get; set; }

        public int ObjectType { get; set; }

        public int DeviceTypeId { get; set; }

        public string Color { get; set; }

        public bool ColorInherited { get; set; }

        public string CostCenterCode { get; set; }

        public int GroupId { get; set; }

        public string ParentName { get; set; }

        public string VehicleFullPath { get; set; }

        public int? DriverId { get; set; }

        public bool HasGps { get; set; }

        public int? CostCenterId { get; set; }

        public string ExternalId { get; set; }

        public string EvidenceNumber { get; set; }
    }
}

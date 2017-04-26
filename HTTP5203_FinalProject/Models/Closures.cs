using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace HTTP5203_FinalProject.Models
{
    [Serializable]
    [XmlRoot("Closures"), XmlType("Closures")]
    public class Closures
    {
        public string Id { get; set; }
        public string Road { get; set; }
        public string Name { get; set; }
        public string District { get; set; }
        public double Latitude { get; set; }
        public double Longitute { get; set; }
        public string RoadClass { get; set; }
        public int Planned { get; set; }
        public int SeverityOverride { get; set; }
        public string Source { get; set; }
        public string LastUpdated { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string WorkPeriod { get; set; }
        public int Expired { get; set; }
        public string Signing { get; set; }
        public string Notification { get; set; }
        public string WorkEventType { get; set; }
        public string Contractor { get; set; }
        public string PermitType { get; set; }
        public string Description { get; set; }
        public string SpecialEvent { get; set; }
    }
}
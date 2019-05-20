using System.Runtime.Serialization;
using Innoactive.Hub.Persistence;

namespace Innoactive.HubTutorial
{
    [DataContract]
    public class BatteryPersistenceData : PersistentProperty.PropData
    {
        // protocol version to ensure correct versions - increment whenever you change the object definition
        public new const uint protocolVersion = PersistentProperty.PropData.protocolVersion + 1;

        public const string propertyType = "Battery";

        public BatteryPersistenceData() : base(propertyType)
        {
        }

        [DataMember(Name = "current_charge")]
        public float? CurrentCharge { get; set; }
    }
}

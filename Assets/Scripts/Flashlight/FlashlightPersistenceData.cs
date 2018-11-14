using Innoactive.Hub.Persistence;
using System.Runtime.Serialization;

namespace HubTutorial
{
    /// <summary>
    /// Persistent data that contains information to re-create a <see cref="Flashlight"/>.
    /// </summary>
    [DataContract]
    public class FlashlightPersistenceData : PersistentProperty.PropData
    {
        // protocol version to ensure correct versions - increment whenever you change the object definition
        public new const uint protocolVersion = PersistentProperty.PropData.protocolVersion + 1;

        public const string propertyType = "Flashlight";

        public FlashlightPersistenceData() : base(propertyType) { }

        // TODO Chapter 10: Create data fields that need to be persisted.
    }
}

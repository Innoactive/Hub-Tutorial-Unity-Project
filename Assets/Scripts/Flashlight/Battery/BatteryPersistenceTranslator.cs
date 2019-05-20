using Innoactive.Hub.Persistence.Unity;
using UnityEngine;

namespace Innoactive.HubTutorial
{
    /// <summary>
    /// Translator used to save or load <see cref="BatteryPersistenceData"/> from or into a <see cref="Battery"/>.
    /// </summary>
    public class BatteryPersistenceTranslator : SingleComponentPropertyTranslator<BatteryPersistenceData, Battery>
    {
        public override uint Priority
        {
            get
            {
                return 128;
            }
        }

        public override string PropertyTypeName
        {
            get
            {
                return BatteryPersistenceData.propertyType;
            }
        }

        protected override void UpdatePropertyFromComponent(Battery component, BatteryPersistenceData data, UnityPersistenceConfiguration config)
        {
            data.CurrentCharge = component.CurrentCharge;
        }

        protected override void UpdateComponentFromProperty(BatteryPersistenceData data, Battery component, UnityPersistenceConfiguration config)
        {
            if (data.CurrentCharge != null)
            {
                component.SetCharge(data.CurrentCharge.Value);
            }
        }
    }
}

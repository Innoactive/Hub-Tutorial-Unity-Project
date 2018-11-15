using Innoactive.Hub.Persistence.Unity;

namespace HubTutorial
{
    /// <summary>
    /// Component that translates component representing a <see cref="Flashlight"/>.
    /// </summary>
    public class FlashlightPersistenceTranslator : SingleComponentPropertyTranslator<FlashlightPersistenceData, Flashlight>
    {
        /// <inheritdoc />
        public override string PropertyTypeName
        {
            get
            {
                return FlashlightPersistenceData.propertyType;
            }
        }

        /// <inheritdoc />
        public override uint Priority
        {
            get
            {
                return 0;
            }
        }

        /// <inheritdoc />
        protected override void UpdateComponentFromProperty(FlashlightPersistenceData data, Flashlight component, UnityPersistenceConfiguration config)
        {
            // TODO: Set values of flashlight according to the retrieved persisted data
            if (data.EnableState != null)
            {
                component.SetLightState(data.EnableState.Value);
            }

            if (data.SpreadAngle != null)
            {
                component.ChangeSpreadAngle(data.SpreadAngle.Value);
            }
        }

        /// <inheritdoc />
        protected override void UpdatePropertyFromComponent(Flashlight component, FlashlightPersistenceData data, UnityPersistenceConfiguration config)
        {
            // TODO: Set data to persist according to the values of the flashlight
            data.EnableState = component.IsLightOn;
            data.SpreadAngle = component.SpreadAngle;
        }
    }
}

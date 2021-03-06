﻿using Innoactive.Hub.Persistence.Unity;

namespace Innoactive.HubTutorial
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
                // TODO Chapter 10: Return property type of the persistent flashlight data.
                return null;
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
            // TODO Chapter 10: Set values of flashlight according to the retrieved persisted data.
        }

        /// <inheritdoc />
        protected override void UpdatePropertyFromComponent(Flashlight component, FlashlightPersistenceData data, UnityPersistenceConfiguration config)
        {
            // TODO Chapter 10: Set data to persist according to the values of the flashlight.
        }
    }
}
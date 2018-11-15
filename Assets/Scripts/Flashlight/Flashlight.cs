using System;
using Innoactive.Hub.Interaction;
using UnityEngine;
using VRTK;

namespace HubTutorial
{
    /// <summary>
    /// Flashlight tool which can be turned on and off.
    /// Also the spread angle of the light can be adjusted.
    /// </summary>
    public class Flashlight : InteractableObject
    {
        // Logger to get sufficient log information
        private static readonly Common.Logging.ILog logger = Innoactive.Hub.Logging.LogManager.GetLogger<Flashlight>();

        #region Events
        #region EventArgs

        /// <summary>
        /// Event arguments to pass the current state of the light (on or off).
        /// </summary>
        public class LightStateChangedEventArgs : EventArgs
        {
            public readonly bool NewState;
            public LightStateChangedEventArgs(bool newState)
            {
                NewState = newState;
            }
        }

        /// <summary>
        /// Event arguments to pass the spread angle of the light.
        /// </summary>
        public class SpreadChangedEventArgs : EventArgs
        {
            public readonly float NewSpread;
            public SpreadChangedEventArgs(float newSpread)
            {
                NewSpread = newSpread;
            }
        }
        #endregion

        /// <summary>
        /// Event emitted when light is turned on or off.
        /// </summary>
        public event EventHandler<LightStateChangedEventArgs> LightStateChanged;

        /// <summary>
        /// Event emitted when spread angle of light is changed.
        /// </summary>
        public event EventHandler<SpreadChangedEventArgs> SpreadChanged;
        #endregion

        [SerializeField]
        [Tooltip("Light source of flashlight.")]
        private Light lightToToggle = null;

        [SerializeField]
        [Tooltip("Spread angle of flashlight.")]
        private float spreadAngle = 25.0f;

        /// <summary>
        /// Spread angle of flashlight.
        /// </summary>
        public float SpreadAngle
        {
            get
            {
                return spreadAngle;
            }
        }

        /// <summary>
        /// Is the light currently turned on.
        /// </summary>
        public bool IsLightOn
        {
            get
            {
                return lightToToggle.enabled;
            }
        }

        protected virtual void Awake()
        {
            // TODO Chapter 6: Initially turn light off and set intial spread angle

            // In Awake we make sure a light is set...
            if (lightToToggle == null)
            {
                logger.Error("No light assigned!");
            }
            else
            {
                lightToToggle.enabled = false;
            }

            // ...and also broadcast the initial spread angle.
            ChangeSpreadAngle(spreadAngle);
        }

        /// <summary>
        /// Change the spread angle of the flashlight.
        /// </summary>
        /// <param name="spreadAngle">New angle to set</param>
        public void ChangeSpreadAngle(float spreadAngle)
        {
            // TODO Chapter 6: Set the new spread angle of the light and broadcast new value.
            this.spreadAngle = spreadAngle;
            lightToToggle.spotAngle = spreadAngle;
            if (SpreadChanged != null)
            {
                SpreadChanged.Invoke(this, new SpreadChangedEventArgs(spreadAngle));
            }
        }

        /// <inheritdoc />
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            // TODO Chapter 6: Toggle the light when object is used.
            base.StartUsing(currentUsingObject);

            logger.Debug("Start using flashlight");
            ToggleLight();
        }

        /// <summary>
        /// Toggle the light either on or off, depending on the current state.
        /// </summary>
        public void ToggleLight()
        {
            SetLightState(!IsLightOn);
        }

        /// <summary>
        /// Set the current state of the light, either on or off.
        /// </summary>
        /// <param name="state">New state to be set</param>
        public void SetLightState(bool state)
        {
            // TODO Chapter 6: Set the new state of the light and broadcast the new state.
            if (state != IsLightOn)
            {
                logger.Info("Changing light to " + state);
                lightToToggle.enabled = state;
                if (LightStateChanged != null)
                {
                    LightStateChanged.Invoke(this, new LightStateChangedEventArgs(state));
                }
            }
        }
    }
}

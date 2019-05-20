using System;
using Innoactive.Hub.Interaction;
using UnityEngine;
using VRTK;

namespace Innoactive.HubTutorial
{
    /// <summary>
    /// Flashlight tool which can be turned on and off.
    /// Also the spread angle of the light can be adjusted.
    /// </summary>
    public class Flashlight : MonoBehaviour
    {
        // Logger to get sufficient log information.
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

        [SerializeField]
        [Tooltip("InteractableObject used to determine when the flashlight is being used.")]
        private InteractableObject interactableObject;

        private Battery battery;

        [SerializeField]
        [Tooltip("How much charge the battery loses per second when it is being used.")]
        private float batteryDischargeRate = 4;

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
        public bool IsLightOn { get; set; }

        private void OnEnable()
        {
            battery = GetComponent<Battery>();
            if (battery != null)
            {
                battery.BatteryEmpty += OnBatteryEmpty;
            }

            // TODO Chapter 6: Initially turn light off and set initial spread angle.
            SetLightState(false);
            ChangeSpreadAngle(SpreadAngle);

            if (interactableObject != null)
            {
                interactableObject.InteractableObjectUsed += OnStartUsing;
            }
        }


        private void OnDisable()
        {
            if (interactableObject != null)
            {
                interactableObject.InteractableObjectUsed -= OnStartUsing;
            }
        }

        /// <summary>
        /// Change the spread angle of the flashlight.
        /// </summary>
        /// <param name="spreadAngle">New angle to set</param>
        public void ChangeSpreadAngle(float spreadAngle)
        {
            // TODO Chapter 6: Set the new spread angle of the light and broadcast new value.
            if (lightToToggle == null || spreadAngle == lightToToggle.spotAngle)
            {
                return;
            }

            lightToToggle.spotAngle = spreadAngle;
            this.spreadAngle = spreadAngle;
            if (SpreadChanged != null)
            {
                SpreadChanged.Invoke(this, new SpreadChangedEventArgs(spreadAngle));
            }
        }

        /// <summary>
        /// Called when the <see cref="InteractableObject"/> starts being used.
        /// </summary>
        private void OnStartUsing(object sender, InteractableObjectEventArgs e)
        {
            // TODO Chapter 6: Toggle the light when object is used.
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
            if (state && CanTurnOn() == false)
            {
                return;
            }

            // TODO Chapter 6: Set the new state of the light and broadcast the new state.
            if (lightToToggle == null || lightToToggle.enabled == state)
            {
                return;
            }

            lightToToggle.enabled = state;
            IsLightOn = state;
            if (LightStateChanged != null)
            {
                LightStateChanged.Invoke(this, new LightStateChangedEventArgs(state));
            }
        }

        private bool CanTurnOn()
        {
            return battery != null && battery.CurrentCharge > 0;
        }

        private void OnBatteryEmpty(object sender, Battery.BatteryEventArgs e)
        {
            SetLightState(false);
        }

        private void Update()
        {
            ConsumeBattery();
        }

        private void ConsumeBattery()
        {
            if (battery == null || IsLightOn == false)
            {
                return;
            }

            battery.DishargeBattery(batteryDischargeRate * Time.deltaTime);
        }
    }
}

using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Innoactive.HubTutorial
{
    /// <summary>
    /// Example class allowing to use batteries in tools. They can be charged, discharged and emit events when they are full or empty.
    /// </summary>
    public class Battery : MonoBehaviour
    {
        public class BatteryEventArgs : EventArgs
        {
            public float BatteryCharge { get; set; }
            public float MaxCharge { get; set; }

            public BatteryEventArgs(Battery battery)
            {
                BatteryCharge = battery.CurrentCharge;
                MaxCharge = battery.MaxCharge;
            }
        }

        /// <summary>
        /// Event fired when the charge changed and the battery ends up full.
        /// </summary>
        public event EventHandler<BatteryEventArgs> BatteryFullyCharged;

        /// <summary>
        /// Event fired when the charge changed and the battery ends up empty.
        /// </summary>
        public event EventHandler<BatteryEventArgs> BatteryEmpty;

        /// <summary>
        /// Event fired when the charge changed.
        /// </summary>
        public event EventHandler<BatteryEventArgs> BatteryChargeChanged;

        [FormerlySerializedAs("charge")]
        [Tooltip("Current charge of the battery")]
        [SerializeField]
        private float currentCharge = 100;

        /// <summary>
        /// Current charge of the battery.
        /// </summary>
        public float CurrentCharge
        {
            get
            {
                return currentCharge;
            }
        }

        [Tooltip("Maximum charge of the battery. Defines when the battery is full.")]
        [SerializeField]
        private float maxCharge = 100;

        /// <summary>
        /// Maximum charge of the battery. Defines when the battery is full.
        /// </summary>
        public float MaxCharge
        {
            get
            {
                return maxCharge;
            }
            set
            {
                maxCharge = value;
            }
        }

        /// <summary>
        /// The normalized current charge.
        /// </summary>
        public float CurrentChargeNormalized
        {
            get
            {
                return CurrentCharge / MaxCharge;
            }
        }

        /// <summary>
        /// Add battery charge.
        /// </summary>
        public void ChargeBattery(float amount)
        {
            SetCharge(currentCharge + amount);
        }

        /// <summary>
        /// Reduce battery charge.
        /// </summary>
        public void DishargeBattery(float amount)
        {
            ChargeBattery(-amount);
        }

        /// <summary>
        /// Sets the battery charge to the passed value, clamped by the <see cref="MaxCharge"/>.
        /// </summary>
        public void SetCharge(float newCharge)
        {
            newCharge = Mathf.Clamp(newCharge, 0, maxCharge);

            if (Math.Abs(newCharge - currentCharge) < 0.001f)
            {
                return;
            }

            currentCharge = newCharge;

            if (BatteryChargeChanged != null)
            {
                BatteryChargeChanged.Invoke(this, new BatteryEventArgs(this));
            }

            if (currentCharge <= 0)
            {
                if (BatteryEmpty != null)
                {
                    BatteryEmpty.Invoke(this, new BatteryEventArgs(this));
                }
            }
            else if (currentCharge >= maxCharge)
            {
                if (BatteryFullyCharged != null)
                {
                    BatteryFullyCharged.Invoke(this, new BatteryEventArgs(this));
                }
            }
        }
    }
}

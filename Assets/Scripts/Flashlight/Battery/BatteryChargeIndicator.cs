using UnityEngine;
using UnityEngine.UI;

namespace Innoactive.HubTutorial
{
    /// <summary>
    /// Helper class allowing to visualize the current battery charge using a UI Slider.
    /// </summary>
    public class BatteryChargeIndicator : MonoBehaviour
    {
        [Tooltip("Slider used to visualize the current battery charge.")]
        [SerializeField]
        protected Slider indicator;

        [Tooltip("Target battery whose charge is displayed.")]
        [SerializeField]
        protected Battery battery;

        /// <summary>
        /// Sets default values when the component is added to a GameObject.
        /// </summary>
        protected virtual void Reset()
        {
            if (indicator == null)
            {
                indicator = GetComponent<Slider>();
            }

            if (battery == null)
            {
                battery = GetComponentInParent<Battery>();
            }
        }

        protected virtual void OnEnable()
        {
            if (battery != null)
            {
                battery.BatteryChargeChanged += OnBatteryChargeChanged;
            }

            UpdateIndicator();
        }

        protected virtual void OnDisable()
        {
            if (battery != null)
            {
                battery.BatteryChargeChanged -= OnBatteryChargeChanged;
            }
        }

        /// <summary>
        /// Called whenever the battery charge changes.
        /// </summary>
        protected virtual void OnBatteryChargeChanged(object sender, Battery.BatteryEventArgs args)
        {
            UpdateIndicator();
        }

        /// <summary>
        /// Update the current battery charge visualization.
        /// </summary>
        protected virtual void UpdateIndicator()
        {
            if (indicator == null)
            {
                return;
            }

            indicator.value = battery.CurrentChargeNormalized;
        }
    }
}

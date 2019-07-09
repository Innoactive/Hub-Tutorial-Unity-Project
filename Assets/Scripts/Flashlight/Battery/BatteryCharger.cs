using Common.Logging;
using Innoactive.Hub.Interaction;
using UnityEngine;
using VRTK;

namespace Innoactive.HubTutorial
{
    /// <summary>
    /// Component which charges batteries attached to the connected <see cref="SnapDropZone"/>.
    /// </summary>
    public class BatteryCharger : MonoBehaviour
    {
        private static readonly ILog logger = Innoactive.Hub.Logging.LogManager.GetLogger<BatteryCharger>();

        private SnapDropZone snapZone;
        private Battery battery;

        [Tooltip("Charge per second.")]
        [SerializeField]
        private float ChargeRate = 10;

        private void Update()
        {
            if (battery == null)
            {
                return;
            }

            battery.ChargeBattery(ChargeRate * Time.deltaTime);
        }

        private void OnEnable()
        {
            snapZone = GetComponent<SnapDropZone>();

            if (snapZone == null)
            {
                logger.Error("No SnapDropZone found. Charger will not work.");
                return;
            }

            snapZone.ObjectSnappedToDropZone += OnSnap;
            snapZone.ObjectUnsnappedFromDropZone += OnUnsnap;
        }

        private void OnDisable()
        {
            if (snapZone == null)
            {
                logger.Error("No SnapDropZone assigned. Charger can not unsubscribe from events.");
                return;
            }

            snapZone.ObjectSnappedToDropZone -= OnSnap;
            snapZone.ObjectUnsnappedFromDropZone -= OnUnsnap;
        }

        private void OnSnap(object sender, SnapDropZoneEventArgs snapDropZoneEventArgs)
        {
            battery = snapZone.GetCurrentSnappedObject().GetComponentInChildren<Battery>();
        }

        private void OnUnsnap(object sender, SnapDropZoneEventArgs e)
        {
            battery = null;
        }
    }
}

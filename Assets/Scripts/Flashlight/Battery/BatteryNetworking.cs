using System.Collections.Generic;
using UnityEngine;

namespace Innoactive.HubTutorial
{
    /// <summary>
    /// Networking component taking care of battery synchronization.
    /// </summary>
    [RequireComponent(typeof(PhotonView), typeof(Battery))]
    public class BatteryNetworking : MonoBehaviour, IPunObservable
    {
        private Battery battery;
        private PhotonView photonView;

        private void OnEnable()
        {
            battery = GetComponent<Battery>();
            photonView = GetComponent<PhotonView>();

            // TODO Chapter 11: Add this component to the ObservedComponents list in the photonview.
            if (photonView.ObservedComponents == null)
            {
                photonView.ObservedComponents = new List<Component>();
            }

            photonView.ObservedComponents.Add(this);
        }

        private void OnDisable()
        {
            photonView.ObservedComponents.Remove(this);
        }

        /// <summary>
        /// Used by photon to synchronize the current battery charge.
        /// </summary>
        public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
        {
            // TODO Chapter 11: Serialize the battery charge in the PhotonStream and set the battery charge when the stream is not writing.
            float charge = battery.CurrentCharge;
            stream.Serialize(ref charge);

            if (stream.isWriting == false)
            {
                battery.SetCharge(charge);
            }
        }
    }
}

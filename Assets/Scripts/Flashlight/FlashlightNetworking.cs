using System;
using Innoactive.Hub.Commands;
using Innoactive.Hub.Interaction;
using UnityEngine;

namespace HubTutorial
{
    /// <summary>
    /// Networking component enabling networking for the <see cref="Flashlight"/> tool.
    /// </summary>
    [RequireComponent(typeof(Flashlight))]
    public class FlashlightNetworking : InteractableObjectNetworking
    {
        // Logger to get sufficient log information.
        private static readonly Common.Logging.ILog logger = Innoactive.Hub.Logging.LogManager.GetLogger<Flashlight>();

        /// <summary>
        /// Reference to the flashlight.
        /// </summary>
        private Flashlight flashlight;

        /// <summary>
        /// Is lock active to prevent recursion on RPC calls between multiple clients.
        /// </summary>
        private bool recursionLockActive = false;

        #region HubCommand

        /// <summary>
        /// <see cref="HubCommand"/> to change the state (on or off) of the flashlight.
        /// </summary>
        [Serializable]
        public class LightStateChangedCommand : HubCommand
        {
            /// <summary>
            /// State of the flashlight (on or off).
            /// </summary>
            public bool LightState;

            /// <summary>
            /// Reference to the <see cref="Flashlight"/> GameObject.
            /// </summary>
            public GameObjectReference FlashlightReference;

            public LightStateChangedCommand() { }

            public LightStateChangedCommand(FlashlightNetworking flashlight, bool lightState)
            {
                // TODO: Set public fields accordingly.
                FlashlightReference = new GameObjectReference(flashlight);
                LightState = lightState;
            }

            /// <inheritdoc />
            public override void Execute(bool isLocal)
            {
                // TODO: Implement execution to set new state
                FlashlightReference.Get(UpdateTarget);
            }

            private void UpdateTarget(GameObject target)
            {
                // TODO: Update the state of your flashlight
                FlashlightNetworking flashlight = target.GetComponent<FlashlightNetworking>();
                flashlight.RemoteChangeLightState(LightState);
            }
        }
        #endregion

        protected override void OnEnable()
        {
            flashlight = GetComponent<Flashlight>();

            // TODO: Subscribe to events

            flashlight.LightStateChanged += FlashlightStateChanged;
            flashlight.SpreadChanged += FlashlightSpreadChanged;
        }

        private void OnDisable()
        {
            // TODO: Unsubscribe to events to avoid errors when object is deleted

            flashlight.LightStateChanged -= FlashlightStateChanged;
            flashlight.SpreadChanged -= FlashlightSpreadChanged;
        }

        /// <summary>
        /// Will be triggered when spread angle of the flashlight changed.
        /// </summary>
        /// <param name="sender">Object which emitted this event</param>
        /// <param name="args">Arguments which hold information about the current spread angle</param>
        private void FlashlightSpreadChanged(object sender, Flashlight.SpreadChangedEventArgs args)
        {
            // TODO: Change spread angle for all other users using the photon RPC call.
            if (recursionLockActive == false)
            {
                photonView.RPC("RemoteSpreadChanged", PhotonTargets.Others, args.NewSpread);
            }
        }

        /// <summary>
        /// Will be triggered when the state (on or off) of the flashlight changed.
        /// </summary>
        /// <param name="sender">Object which emitted this event</param>
        /// <param name="args">Arguments which hold information about the current state</param>
        private void FlashlightStateChanged(object sender, Flashlight.LightStateChangedEventArgs args)
        {
            // TODO: Change state of light for all other users using HubCommand.
            if (recursionLockActive == false)
            {
                new LightStateChangedCommand(this, args.NewState).Execute();
            }
        }

        /// <summary>
        /// Networked method to call <see cref="SetLightState"/>.
        /// </summary>
        /// <param name="lightState">New state of the light</param>
        private void RemoteChangeLightState(bool lightState)
        {
            recursionLockActive = true;
            flashlight.SetLightState(lightState);
            recursionLockActive = false;
        }

        /// <summary>
        /// Networked method to call <see cref="ChangeSpreadAngle"/>.
        /// </summary>
        /// <param name="newSpread">New spread angle of the light</param>
        [PunRPC]
        private void RemoteSpreadChanged(float newSpread)
        {
            recursionLockActive = true;
            flashlight.ChangeSpreadAngle(newSpread);
            recursionLockActive = false;
        }
    }
}

using System;
using UnityEngine;

namespace Innoactive.HubTutorial
{
    /// <summary>
    /// Class allowing to switch between different lights and skymaps.
    /// Can be used to toggle day and night.
    /// </summary>
    public class LightSetupController : MonoBehaviour
    {
        [Serializable]
        public struct LightSetup
        {
            /// <summary>
            /// Name displayed in the menu.
            /// </summary>
            public string Name;

            /// <summary>
            /// Light enabled when selected.
            /// </summary>
            public Light AffectedLight;

            /// <summary>
            /// Skymap material to be used.
            /// </summary>
            public Material SkyMaterial;
        }

        /// <summary>
        /// Instance of <see cref="LightSetupController"/> allowing to access it globally.
        /// </summary>
        public static LightSetupController Instance { get; private set; }

        [Tooltip("Light setups.")]
        [SerializeField]
        private LightSetup[] lightSets;

        /// <summary>
        /// Available Light Setups.
        /// </summary>
        public LightSetup[] LightSets
        {
            get
            {
                return lightSets;
            }
            set
            {
                lightSets = value;
            }
        }

        private void OnEnable()
        {
            Instance = this;
            SetLight(0);
        }

        /// <summary>
        /// Select the Light Setup to be used.
        /// </summary>
        public void SetLight(int lightSetIndex)
        {
            SetLight(LightSets[lightSetIndex]);
        }

        /// <summary>
        /// Select the Light Setup to be used.
        /// </summary>
        public void SetLight(LightSetup lightSet)
        {
            // First disable all, only then enable. This prevents errors when using the same light in different setups.
            foreach (LightSetup lightSetup in lightSets)
            {
                lightSetup.AffectedLight.enabled = false;
            }

            lightSet.AffectedLight.enabled = true;

            RenderSettings.skybox = lightSet.SkyMaterial;
        }
    }
}

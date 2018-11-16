using Innoactive.Hub.Settings;
using Innoactive.Hub.UI;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

namespace HubTutorial
{
    /// <summary>
    /// Extension of the context actions for the flashlight tool.
    /// Adds two new buttons which increase and decrease the size of the spread angle of the light source.
    /// </summary>
    [RequireComponent(typeof(Flashlight))]
    public class FlashlightContextActions : ContextAction
    {
        // Logger to get sufficient log information.
        private static readonly Common.Logging.ILog logger = Innoactive.Hub.Logging.LogManager.GetLogger<FlashlightContextActions>();

        /// <summary>
        /// Reference to the flashlight tool.
        /// </summary>
        private Flashlight flashlight = null;

        /// <summary>
        /// Define new buttons in the context menu of the flashlight.
        /// </summary>
        /// <returns>List of buttons to add</returns>
        protected override List<IMenuItem> GetAvailableButtons()
        {
            // Make sure reference to flashlight tool is set.
            flashlight = GetComponent<Flashlight>();

            List<IMenuItem> buttons = new List<IMenuItem>();

            // TODO Chapter 7: Create and add new buttons to increase and decrease flashlight spread angle.
            // using default design defined in the HubSettings and the icons which can be found in the resources folder.

            return buttons;
        }

        /// <summary>
        /// Decrease the spread angle of the flashlight.
        /// </summary>
        /// <param name="controller">Reference to the controller events which triggered this method</param>
        private void DecreaseSpread(VRTK_ControllerEvents controller)
        {
            // TODO Chapter 7: Set new spread angle of flashlight. At least 10.
        }

        /// <summary>
        /// Increase the spread angle of the flashlight.
        /// </summary>
        /// <param name="controller">Reference to the controller events which triggered this method</param>
        private void IncreaseSpread(VRTK_ControllerEvents controller)
        {
            // TODO Chapter 7: Set new spread angle of flashlight. At most 120.
        }
    }
}

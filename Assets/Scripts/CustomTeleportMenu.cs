using System;
using Innoactive.Hub.UI;
using Innoactive.Hub.UI.WindowSystem;
using UnityEngine;
using VRTK;

namespace HubTutorial
{
    /// <summary>
    /// Custom entry to the main menu to teleport to defined positions
    /// and also to open a custom window which shows the current user position.
    /// </summary>
    public class CustomTeleportMenu : Menu, IMenuProvider
    {
        // Logger to get sufficient log information.
        private static readonly Common.Logging.ILog logger = Innoactive.Hub.Logging.LogManager.GetLogger<CustomTeleportMenu>();

        public CustomTeleportMenu()
        {
            AddButtons();
            CustomizeWindowFactory();
        }

        /// <summary>
        /// Adds custom buttons to this menu.
        /// </summary>
        private void AddButtons()
        {
            // TODO Chapter 8: Add three buttons to the menu:
            // first called "Teleport To 1" which teleports the user to world origin
            // second called "Teleport To 2" which teleports the user to 1, 0, 0
            // third called "Teleport To 3" which teleports the user to 2, 0, 0.

            // TODO Chapter 12: Add a fourth button which opens a custom window showing the current position.
            // with text "Show Position" and with the SettingsIcon from the Hub SDK Resources folder.
        }

        /// <summary>
        /// Customize the Window Factory to fit your own style.
        /// </summary>
        private void CustomizeWindowFactory()
        {
            // TODO Chapter 12: Customize background color (black), text color, color of title, button text color (all white) and border color (red).
        }

        /// <summary>
        /// Show a window that displays the current position of the user.
        /// </summary>
        /// <param name="obj"></param>
        private void ShowCurrentPositionWindow(VRTK_ControllerEvents obj)
        {
            // TODO Chapter 12: Create window with position information.
            // Also display two buttons, one saying "Okay" which closes the window
            // and one saying "Reset" which teleports the user to world origin (and closes the window)
        }

        /// <summary>
        /// Teleports the user to a given position.
        /// </summary>
        /// <param name="position">Position to teleport to</param>
        private void TeleportTo(Vector3 position)
        {
            // TODO Chapter 8: Use VRTK methods to teleport the user to given position.
        }

        public IMenu CreateMenu(MenuPresenter menuPresenter)
        {
            return this;
        }

        public bool IsCachingSupported()
        {
            return true;
        }
    }
}

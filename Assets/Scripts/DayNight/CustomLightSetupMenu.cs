using Innoactive.Hub.UI;

namespace Innoactive.HubTutorial
{
    /// <summary>
    /// Custom entry to the main menu to change the light of the scene.
    /// </summary>
    public class CustomLightSetupMenu : Menu, IMenuProvider
    {
        // Logger to get sufficient log information.
        private static readonly Common.Logging.ILog logger = Innoactive.Hub.Logging.LogManager.GetLogger<CustomLightSetupMenu>();

        public CustomLightSetupMenu()
        {
            AddButtons();
        }

        private LightSetupCommand lightCommand = null;

        /// <summary>
        /// Adds custom buttons to this menu.
        /// </summary>
        private void AddButtons()
        {
            Clear();
            LightSetupController lightSetupController = LightSetupController.Instance;

            if (lightSetupController == null)
            {
                return;
            }

            // TODO Chapter 8: Add a button for each light setup to the menu:
            // Use Add(new ButtonItem(resourceIcon, (controller) => { // Do something. })));
        }


        private void SetLightSetup(int lightSetupIndex)
        {
            // TODO Chapter 8: Set the light setup in the LightSetupController.Instance:

            // TODO Chapter 11: Replace the instance call with a LightSetupCommand. Make sure to invalidate previous lightCommands if available before executing the new one.
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

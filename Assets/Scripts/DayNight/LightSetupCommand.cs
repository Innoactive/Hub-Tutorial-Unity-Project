using System;
using Innoactive.Hub.Commands;

namespace Innoactive.HubTutorial
{
    /// <summary>
    /// Networking class for the <see cref="LightSetupController"/>.
    /// </summary>
    [Serializable]
    public class LightSetupCommand : HubCommand
    {
        public int LightSetupIndex { get; set; }

        public LightSetupCommand()
        {
        }

        public LightSetupCommand(int lightSetupIndex)
        {
            // TODO Chapter 11: Set public field accordingly.
        }

        public override void Execute(bool isLocal)
        {
            // TODO Chapter 11: Implement execution to set new state in the LightSetupController.Instance.
        }
    }
}

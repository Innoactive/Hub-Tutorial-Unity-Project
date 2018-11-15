using Innoactive.Hub.Persistence;
using Innoactive.Hub.Persistence.Unity;

namespace HubTutorial
{
    /// <summary>
    /// Extension of the persistence config for this tutorial project.
    /// </summary>
    public class TutorialPersistenceExtension : PersistenceConfigExtension
    {
        /// <inheritdoc />
        public override void ExtendPerisistenceConfig(PersistenceConfiguration config)
        {
            // TODO Chapter 10: Register flashlight persistence
            config.PropertyTranslators.RegisterTranslator(new FlashlightPersistenceTranslator());
        }
    }
}

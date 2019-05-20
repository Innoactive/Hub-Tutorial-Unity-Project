using System.Collections;
using System.Collections.Generic;
using Innoactive.Hub.UI.WindowSystem;
using UnityEngine;

namespace Innoactive.HubTutorial
{
    /// <summary>
    /// Example class showing how to use the <see cref="WindowFactory"/>.
    /// </summary>
    public class InfoWindow : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("Delay in seconds between component enable and the window opening.")]
        private float delay = 0;

        [SerializeField]
        [Tooltip("The window title.")]
        private string title = "myTitle";

        [SerializeField]
        [Tooltip("The content displayed in the window.")]
        private string content = "Content";

        private void OnEnable()
        {
            CustomizeWindowFactory();
            StartCoroutine(DelayedWindow());
        }

        private IEnumerator DelayedWindow()
        {
            yield return new WaitForSeconds(delay);
            WindowFactory.Instance.CreateActionsWindow(content, title, new[] { new WindowFactory.Button(null, "Okay", null, true) }).Open();
        }

        /// <summary>
        /// Customize the Window Factory to fit your own style.
        /// </summary>
        private void CustomizeWindowFactory()
        {
            // Customize background color, text color, color of title, button text color and border color.
            WindowFactory.Instance.Config.backgroundColor = new Color(0.066f, 0.098f, 0.16f);
            WindowFactory.Instance.Config.textColor = new Color(0.31f, 0.776f, 0.878f);
            WindowFactory.Instance.Config.titleTextColor = new Color(0.19f, 0.674f, 0.8f);
            WindowFactory.Instance.Config.buttonTextColor = new Color(0.19f, 0.674f, 0.8f);
            WindowFactory.Instance.Config.borderColor = new Color(0.2f, 0.25f, 0.345f);
            WindowFactory.Instance.Config.buttonColor = new Color(0.2f, 0.25f, 0.345f);
        }
    }
}

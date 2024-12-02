using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase.Infrastructure.UI.MainMenu
{
    public class TapPlayButton : MonoBehaviour
    {
        [SerializeField]
        private string _sceneName;

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
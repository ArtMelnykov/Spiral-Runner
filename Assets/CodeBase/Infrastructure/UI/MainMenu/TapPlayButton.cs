using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase.Infrastructure.UI.MainMenu
{
    public class TapPlayButton : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField]
        private string _sceneName;

        public void LoadScene(string sceneName) => 
            SceneManager.LoadScene(sceneName);
    }
}
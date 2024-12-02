using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase.Infrastructure
{
    public class SceneLoader
    {
        private readonly ICoroutineRunner _coroutineRunner;
        
        public SceneLoader(ICoroutineRunner coroutineRunner)
        {
            _coroutineRunner = coroutineRunner;
        }
        
        public void Load(string sceneName) => 
            _coroutineRunner.StartCoroutine(LoadSceneAsync(sceneName));

        private IEnumerator LoadSceneAsync(string sceneName, Action onLoaded = null)
        {
            if (SceneManager.GetActiveScene().name == sceneName)
            {
                onLoaded?.Invoke();
                yield break;
            }
            
            AsyncOperation waitNexScene = SceneManager.LoadSceneAsync(sceneName);
            
            while (!waitNexScene.isDone)
            {
                // Loading screen
                
                yield return null;
            }
            
            onLoaded?.Invoke();
        }
    }
}
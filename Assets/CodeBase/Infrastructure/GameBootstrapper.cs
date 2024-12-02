using CodeBase.Infrastructure.States;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour, ICoroutineRunner
    {
        private Game _game;
        
        private LoadingCurtain _loadingCurtain;

        void Awake()
        {
            _game = new Game(this, _loadingCurtain);
            
            _game.GameStateMachine.Enter<BootstrapState>();
            
            DontDestroyOnLoad(this);
        }
    }
}
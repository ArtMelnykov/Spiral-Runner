namespace CodeBase.Infrastructure.States
{
    public class BootstrapState : IState
    {
        private const string InitialState = "MainMenu";
        private GameStateMachine _gameStateMachine;
        private readonly SceneLoader _sceneLoader;
        
        public BootstrapState(GameStateMachine gameStateMachine, SceneLoader sceneLoader)
        {
            _gameStateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
        }
        
        public void Enter() => _sceneLoader.Load(InitialState);

        public void Exit()
        {
        }
    }
}
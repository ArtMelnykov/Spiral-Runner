using CodeBase.Infrastructure.States;

namespace CodeBase.Infrastructure
{
    public class Game
    {
        public readonly GameStateMachine GameStateMachine;

        public Game(ICoroutineRunner coroutineRunner, LoadingCurtain loadingCurtain)
        {
            GameStateMachine = new GameStateMachine(new SceneLoader(coroutineRunner), loadingCurtain);
        }
    }
}
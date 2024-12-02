namespace CodeBase.Infrastructure.States
{
    public interface IPayloadedState<TPayloaded> : IExitableState 
    {
        void Enter(TPayloaded payloaded);
    }
}
namespace CodeBase.Infrastructure.Services
{
    public class ServiceLocator
    {
        private static ServiceLocator _instance;
        public static ServiceLocator Container => _instance ?? (_instance = new ServiceLocator());

        public void RegisterSingle<TService>(TService implementationService) where TService : IService => 
            Implementation<TService>.ServiceInstance = implementationService;

        public TService Single<TService>() where TService : IService => 
            Implementation<TService>.ServiceInstance;

        private static class Implementation<TService> where TService : IService
        {
            public static TService ServiceInstance;
        } 
    }
}
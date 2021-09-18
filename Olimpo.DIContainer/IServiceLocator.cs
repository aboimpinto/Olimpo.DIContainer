using Microsoft.Extensions.DependencyInjection;

namespace Olimpo.DIContainer
{
    public interface IServiceLocator
    {
        ServiceCollection ServiceCollection { get; set; }

        ServiceProvider ServiceProvider { get; }
    }
}

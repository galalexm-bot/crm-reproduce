using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace EleWise.ELMA.Runtime.AOP;

public interface IAsyncInterceptor : IInterceptor
{
	Task InterceptAsync(IInvocationAsync invocation, CancellationToken cancellationToken);
}

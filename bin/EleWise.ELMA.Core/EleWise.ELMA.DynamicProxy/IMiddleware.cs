using System.Threading.Tasks;

namespace EleWise.ELMA.DynamicProxy;

public interface IMiddleware
{
	System.Threading.Tasks.Task Call(InvocationContext invocationContext);
}

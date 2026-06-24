using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace EleWise.ELMA.Runtime.AOP;

public interface IInvocationAsync : IInvocation
{
	Task ProceedAsync();
}

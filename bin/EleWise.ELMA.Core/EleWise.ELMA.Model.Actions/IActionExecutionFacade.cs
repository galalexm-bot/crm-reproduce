using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Actions;

[ServiceContract]
public interface IActionExecutionFacade
{
	System.Threading.Tasks.Task Execute(IActionExecutionContext context);

	System.Threading.Tasks.Task<TResult> Execute<TResult>(IActionExecutionContext context);

	System.Threading.Tasks.Task Execute<TParam>(IActionExecutionContext context, TParam parameter);

	System.Threading.Tasks.Task<TResult> Execute<TParam, TResult>(IActionExecutionContext context, TParam parameter);
}

using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Actions;

namespace EleWise.ELMA.Core.ExtensionPoints;

[ExtensionPoint]
public interface IActionExecutionHandler
{
	bool Check(IActionExecutionContext context);

	System.Threading.Tasks.Task Execute(IActionExecutionContext context);

	System.Threading.Tasks.Task<TResult> Execute<TResult>(IActionExecutionContext context);

	System.Threading.Tasks.Task Execute<TParam>(IActionExecutionContext context, TParam parameter);

	System.Threading.Tasks.Task<TResult> Execute<TParam, TResult>(IActionExecutionContext context, TParam parameter);
}

using System.Threading.Tasks;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Actions;

internal interface IAbstractServerActionExecutionHandlerWrapper
{
	System.Threading.Tasks.Task Execute(IServerActionExecutionHandler handler, IActionExecutionContext context);
}
internal interface IAbstractServerActionExecutionHandlerWrapperWithParameter
{
	System.Threading.Tasks.Task Execute(IServerActionExecutionHandler handler, IActionExecutionContext context, object parameter);
}
internal interface IAbstractServerActionExecutionHandlerWrapperWithParameterAndResult
{
	System.Threading.Tasks.Task<object> Execute(IServerActionExecutionHandler handler, IActionExecutionContext context, object parameter);
}
internal interface IAbstractServerActionExecutionHandlerWrapperWithResult
{
	System.Threading.Tasks.Task<object> Execute(IServerActionExecutionHandler handler, IActionExecutionContext context);
}

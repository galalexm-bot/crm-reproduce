using System;
using System.Collections;
using System.Threading.Tasks;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.ExtensionPoints;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Model.Actions;

[Component]
internal sealed class EmptyActionExecutionHandler : IActionExecutionHandler
{
	private readonly ILogger logger;

	public EmptyActionExecutionHandler(ILogger logger)
	{
		this.logger = logger;
	}

	public bool Check(IActionExecutionContext context)
	{
		return context.ActionExecutionType == ActionExecutionType.Empty;
	}

	public System.Threading.Tasks.Task Execute(IActionExecutionContext context)
	{
		LogError(ObjectExtensions.As<EmptyActionExecutionContext>((object)context));
		return System.Threading.Tasks.Task.get_CompletedTask();
	}

	public System.Threading.Tasks.Task<TResult> Execute<TResult>(IActionExecutionContext context)
	{
		LogError(ObjectExtensions.As<EmptyActionExecutionContext>((object)context));
		System.Type typeFromHandle = typeof(TResult);
		if (typeFromHandle != typeof(string) && typeof(System.Collections.IEnumerable).IsAssignableFrom(typeFromHandle))
		{
			return System.Threading.Tasks.Task.FromResult<TResult>(ObjectExtensions.As<TResult>((object)typeFromHandle.CreateEmptyEnumerable()));
		}
		return System.Threading.Tasks.Task.FromResult<TResult>(default(TResult));
	}

	public System.Threading.Tasks.Task Execute<TParam>(IActionExecutionContext context, TParam parameter)
	{
		LogError(ObjectExtensions.As<EmptyActionExecutionContext>((object)context));
		return System.Threading.Tasks.Task.get_CompletedTask();
	}

	public System.Threading.Tasks.Task<TResult> Execute<TParam, TResult>(IActionExecutionContext context, TParam parameter)
	{
		LogError(ObjectExtensions.As<EmptyActionExecutionContext>((object)context));
		System.Type typeFromHandle = typeof(TResult);
		if (typeFromHandle != typeof(string) && typeof(System.Collections.IEnumerable).IsAssignableFrom(typeFromHandle))
		{
			return System.Threading.Tasks.Task.FromResult<TResult>(ObjectExtensions.As<TResult>((object)typeFromHandle.CreateEmptyEnumerable()));
		}
		return System.Threading.Tasks.Task.FromResult<TResult>(default(TResult));
	}

	private void LogError(EmptyActionExecutionContext context)
	{
		string text = context.GetActionInfo();
		if (!string.IsNullOrWhiteSpace(text))
		{
			text = SR.T("Дополнительная информация: {0}", text);
		}
		logger.Error(SR.T("Не задано действие. {0}", text));
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Services.FindComponent;
using EleWise.ELMA.Web.Service.Internal.Model;

namespace EleWise.ELMA.Web.Service.Internal;

[Component]
[Uid("{53BBD56B-D1D5-4BC5-9B36-271B54781707}")]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
internal sealed class ActionExecutionService : IActionExecutionService, IInternalAPIWebService
{
	public const string GuidS = "{53BBD56B-D1D5-4BC5-9B36-271B54781707}";

	public static Guid Guid = new Guid("{53BBD56B-D1D5-4BC5-9B36-271B54781707}");

	private static IEnumerable<IActionExecutionHandler> actionExecutionHandlers;

	private static IFindComponentService findComponentService;

	private static IEnumerable<IActionExecutionHandler> ActionExecutionHandlers => actionExecutionHandlers ?? (actionExecutionHandlers = Locator.GetServiceNotNull<IEnumerable<IActionExecutionHandler>>());

	private static IFindComponentService FindComponentService => findComponentService ?? (findComponentService = Locator.GetServiceNotNull<IFindComponentService>());

	private static void LogServiceError(Expression<Action<ActionExecutionService>> method, string message)
	{
		Logger.Log.Error(SR.T("В сервисе \"{0}\" в методе \"{1}\" произошла ошибка: {2}", typeof(ScriptExecutionService), method, message));
	}

	public ActionExecutionResponse Execute(ActionExecutionRequest request)
	{
		if (request == null)
		{
			string text = SR.T("Запрос на исполнение действия пустой");
			LogServiceError((ActionExecutionService s) => s.Execute(request), text);
			return new ActionExecutionResponse
			{
				ExceptionMessage = text
			};
		}
		ActionExecutionParams parameters = request.ToParams();
		IActionExecutionHandler actionExecutionHandler = ActionExecutionHandlers.FirstOrDefault((IActionExecutionHandler handler) => handler.Check(parameters));
		if (actionExecutionHandler == null)
		{
			string text2 = SR.T("Не найдена реализация для исполнения действия");
			LogServiceError((ActionExecutionService s) => s.Execute(request), text2);
			return new ActionExecutionResponse
			{
				ExceptionMessage = text2
			};
		}
		ContextVars.Set("UIBuilderRuntime", request.RuntimeModel ?? new UIRuntimeModel());
		ContextVars.Set("UIBuilderEntityDependencies", request.EntityTypeSerializationSettings);
		ActionExecutionResult actionExecutionResult;
		try
		{
			actionExecutionResult = actionExecutionHandler.Execute(parameters);
		}
		catch (Exception innerException)
		{
			if (innerException is TargetInvocationException)
			{
				innerException = innerException.InnerException;
			}
			LogServiceError((ActionExecutionService s) => s.Execute(request), innerException.ToString());
			return new ActionExecutionResponse
			{
				ExceptionMessage = innerException.Message,
				ExceptionStackTrace = innerException.StackTrace
			};
		}
		ActionExecutionResponse actionExecutionResponse = new ActionExecutionResponse
		{
			AdditionalComponentModels = FindComponentService.GetAdditionalModules().ToArray()
		};
		if (actionExecutionResult.Result is IDictionary<string, object> dictionary)
		{
			actionExecutionResponse.Result = dictionary["Result"];
		}
		return actionExecutionResponse;
	}
}

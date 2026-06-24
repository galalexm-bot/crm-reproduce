using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.ExtensionPoint;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.IntegrationModules.Services;
using EleWise.ELMA.IntegrationModules.Workflow.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Services;

namespace EleWise.ELMA.IntegrationModules.Workflow.Components;

[Component]
internal class ExternalEventWorkflowExecutor : IExternalEventExecutor
{
	private static readonly ILogger IntegrationLogger = Logger.GetLogger("IntegrationModules");

	private IIntegrationModuleScriptingService integrationModuleScriptingService;

	private WorkflowIntegrationBookmarkManager workflowIntegrationBookmarkManager;

	private IWorkflowRuntimeService workflowRuntimeService;

	public ExternalEventWorkflowExecutor(IIntegrationModuleScriptingService integrationModuleScriptingService, WorkflowIntegrationBookmarkManager workflowIntegrationBookmarkManager, IWorkflowRuntimeService workflowRuntimeService)
	{
		this.integrationModuleScriptingService = integrationModuleScriptingService;
		this.workflowIntegrationBookmarkManager = workflowIntegrationBookmarkManager;
		this.workflowRuntimeService = workflowRuntimeService;
	}

	public void Execute(ExternalEvent externalEvent, IIntegrationModule module)
	{
		Contract.ArgumentNotNull(externalEvent, "externalEvent");
		Contract.ArgumentNotNull(module, "module");
		Execute(externalEvent, module, null);
	}

	public void Execute(ExternalEvent externalEvent, IIntegrationModule module, WebData data)
	{
		Contract.ArgumentNotNull(externalEvent, "externalEvent");
		Contract.ArgumentNotNull(module, "module");
		IEnumerable<Guid> enumerable = null;
		try
		{
			IntegrationModuleMetadata integrationMetadata = externalEvent.IntegrationModuleMetadata ?? (MetadataLoader.LoadMetadata(module.CastAsRealType().GetType()) as IntegrationModuleMetadata);
			object obj = integrationModuleScriptingService.ExecuteScript(integrationMetadata, externalEvent.ScriptName, data, new Dictionary<string, object> { 
			{
				IntegrationsConstants.IntegrationParamName,
				module
			} });
			if (obj != null)
			{
				enumerable = obj as IEnumerable<Guid>;
			}
		}
		catch (Exception message)
		{
			IntegrationLogger.Error(message);
			throw new Exception(SR.T("Ошибка выполнения сценария \"{0}\" во внешнем событии \"{1}\" интеграции \"{2}\"", externalEvent.ScriptName, externalEvent.Name, externalEvent.IntegrationModuleMetadata.DisplayName));
		}
		if (enumerable == null)
		{
			return;
		}
		foreach (Guid item in enumerable)
		{
			IEnumerable<IWorkflowIntegrationBookmark> bookmarkByActivityKey = workflowIntegrationBookmarkManager.GetBookmarkByActivityKey(item);
			if (bookmarkByActivityKey.Count() != 1)
			{
				IntegrationLogger.Error(SR.T("Не найдена уникальная точка останова процеса по ключу \"{0}\"", item));
				throw new Exception();
			}
			IntegrationExecuteData integrationExecuteData = new IntegrationExecuteData(bookmarkByActivityKey.FirstOrDefault());
			integrationExecuteData.WebData = data;
			workflowRuntimeService.Execute(integrationExecuteData);
		}
	}
}

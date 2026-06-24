using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Exceptions;
using EleWise.ELMA.IntegrationModules.ExtensionPoint;
using EleWise.ELMA.IntegrationModules.Managers;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.IntegrationModules.Services;

[Service]
internal class ExternalEventService : IExternalEventService
{
	private ISecurityService securityService;

	private IAuthenticationService authenticationService;

	private IEnumerable<IExternalEventExecutor> externalEventExecutors;

	private IntegrationModuleManager integrationModuleManager;

	public ExternalEventService(IEnumerable<IExternalEventExecutor> externalEventExecutors, IntegrationModuleManager integrationModuleManager, ISecurityService securityService, IAuthenticationService authenticationService)
	{
		this.externalEventExecutors = externalEventExecutors;
		this.integrationModuleManager = integrationModuleManager;
		this.securityService = securityService;
		this.authenticationService = authenticationService;
	}

	public bool ExecuteExternalEvent(string eventUrl)
	{
		return ExecuteExternalEventPOST(eventUrl, null);
	}

	public bool ExecuteExternalEventPOST(string eventUrl, WebData data)
	{
		string[] array = eventUrl.Split('$');
		if (array.Count() != 2)
		{
			return false;
		}
		if (!Guid.TryParse(array[0], out var eventUid))
		{
			throw new ExternalEventExecuteException(SR.T("Неверный формат идентификатора ключа Url \"{0}\"", eventUid));
		}
		if (!Guid.TryParse(array[1], out var moduleUid))
		{
			throw new ExternalEventExecuteException(SR.T("Неверный формат идентификатора ключа Url \"{0}\"", moduleUid));
		}
		if (authenticationService.GetCurrentUser() == null)
		{
			bool result = true;
			securityService.RunBySystemUser(delegate
			{
				result = ExecuteExternalEventPOSTInternal(moduleUid, eventUid, data);
			});
			return result;
		}
		return ExecuteExternalEventPOSTInternal(moduleUid, eventUid, data);
	}

	private bool ExecuteExternalEventPOSTInternal(Guid moduleUid, Guid eventUid, WebData data)
	{
		ICollection<IIntegrationModule> collection = integrationModuleManager.Find((IIntegrationModule a) => a.WebApiKey == moduleUid && a.IsTemplate == true);
		if (collection == null || collection.Count != 1)
		{
			throw new ExternalEventExecuteException(SR.T("Не найден модуль интеграции по ключу \"{0}\"", moduleUid));
		}
		IIntegrationModule integrationModule = collection.FirstOrDefault();
		if (!(MetadataLoader.LoadMetadata(integrationModule.GetType()) is IntegrationModuleMetadata integrationModuleMetadata))
		{
			throw new ExternalEventExecuteException(SR.T("Не найдены метаданные модуля интеграции с типом \"{0}\"", integrationModule.GetType().FullName));
		}
		ExternalEvent externalEvent = integrationModuleMetadata.ExternalEvents?.FirstOrDefault((ExternalEvent a) => a.Uid == eventUid);
		if (externalEvent == null)
		{
			throw new ExternalEventExecuteException(SR.T("Не найдено внешнее событие модуля интеграции с идентификатором \"{0}\"", eventUid));
		}
		foreach (IExternalEventExecutor externalEventExecutor in externalEventExecutors)
		{
			externalEventExecutor.Execute(externalEvent, integrationModule, data);
		}
		return true;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.IntegrationModules.Managers;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.IntegrationModules.Deplpoy.Import;

internal sealed class IntegrationModuleHeadImportSaveActions : EntityImportSaveActions
{
	private IntegrationModuleHeaderManager integrationModuleHeaderManager;

	public IntegrationModuleHeadImportSaveActions(IntegrationModuleHeaderManager integrationModuleHeaderManager)
	{
		this.integrationModuleHeaderManager = integrationModuleHeaderManager;
	}

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == InterfaceActivator.UID<IIntegrationModuleHeader>();
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		if (propValues == null)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T("Не выполнены правила импорта: словарь свойств объекта пустой")));
			return false;
		}
		Guid result = Guid.Empty;
		if (propValues.ContainsKey("Uid") && propValues["Uid"] != null)
		{
			Guid.TryParse(propValues["Uid"].ToString(), out result);
		}
		if (result == Guid.Empty)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T("Не выполнены правила импорта: свойство Uid импортируемого объекта - пустое")));
			return false;
		}
		Guid integrationTypeUid = Guid.Empty;
		if (propValues.ContainsKey("IntegrationModuleTyeUid") && propValues["IntegrationModuleTyeUid"] != null)
		{
			Guid.TryParse(propValues["IntegrationModuleTyeUid"].ToString(), out integrationTypeUid);
		}
		if (integrationTypeUid == Guid.Empty)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T("Не выполнены правила импорта: свойство TypeUid импортируемого объекта - пустое")));
			return false;
		}
		List<IIntegrationModuleHeader> list = integrationModuleHeaderManager.Find((IIntegrationModuleHeader h) => h.IntegrationModuleTyeUid == integrationTypeUid).ToList();
		if (list != null && list.Count != 0 && list[0] != null)
		{
			IIntegrationModuleHeader integrationModuleHeader = list[0];
			if (result != integrationModuleHeader.Uid)
			{
				propValues["Uid"] = integrationModuleHeader.Uid.ToString();
			}
		}
		return true;
	}
}

using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Deploy.Import;

internal class SaleStageSaveActions : EntityImportSaveActions
{
	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == InterfaceActivator.UID<ISaleStage>();
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		if (propValues == null)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T("Не выполнены правила импорта: словарь свойств объекта пустой")));
			return false;
		}
		object obj = (propValues.ContainsKey("Uid") ? propValues["Uid"] : null);
		if (obj == null)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T("Не выполнены правила импорта: не передан Uid стадии сделки")));
			return false;
		}
		string key = string.Format("{0}_{1}", "SaleStageColor", obj.ToString());
		if ((data.ServiceData.ContainsKey(key) ? data.ServiceData[key] : null) == null)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T("Не выполнены правила импорта: не обнаружены свойства цвета для импортируемого объекта стадии сделки с Uid={0}", obj.ToString())));
			return false;
		}
		return base.CanBeSaved(propValues, data);
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		if (entity is ISaleStage saleStage)
		{
			string key = string.Format("{0}_{1}", "SaleStageColor", saleStage.Uid);
			string text = (data.ServiceData.ContainsKey(key) ? data.ServiceData[key] : null);
			if (text != null)
			{
				if (saleStage.Color == null)
				{
					saleStage.Color = EntityManager<IColor>.Instance.Create();
				}
				saleStage.Color.ColorCode = text;
			}
		}
		return base.ExecPreSaveActions(entity, data);
	}
}

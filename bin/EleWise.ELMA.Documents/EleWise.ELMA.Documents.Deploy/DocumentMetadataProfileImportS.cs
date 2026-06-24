using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Deploy.Import;

public class DocumentMetadataProfileImportSaveActions : EntityImportSaveActions
{
	public override bool IsSupported(Guid typeGuid)
	{
		if (!(typeGuid == InterfaceActivator.UID<IDocumentMetadataProfile>()))
		{
			return typeGuid == InterfaceActivator.UID<IDocumentMetadataProfile>(loadImplementation: false);
		}
		return true;
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
		Guid result2 = Guid.Empty;
		if (propValues.ContainsKey("DocumentType") && propValues["DocumentType"] != null)
		{
			Guid.TryParse(propValues["DocumentType"].ToString(), out result2);
		}
		if (result2 == Guid.Empty)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T("Не выполнены правила импорта: свойство documentType импортируемого объекта - пустое")));
			return false;
		}
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(result2);
		if (documentMetadataProfile != null && result != documentMetadataProfile.Uid)
		{
			propValues["Uid"] = documentMetadataProfile.Uid.ToString();
		}
		return true;
	}

	public override void ExecPostSaveActions(IEntity entity, Type type, Dictionary<string, object> values, Dictionary<string, string> serviceData, LinksDictionary links)
	{
		DocumentHistoryProfileManager.Instance.ClearCache();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Documents.Deploy.Export;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Deploy.Import;

public class DocumentMetadataHeadImportSaveActions : EntityImportSaveActions
{
	public static readonly Guid UID = new Guid("a30f5ecc-5a9e-4407-91aa-25da43899f4a");

	private static readonly ILogger ImportLog = Logger.GetLogger("ElmaImport");

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == UID;
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		if (propValues == null)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T("Не выполнены правила импорта: словарь свойств объекта пустой")));
			return false;
		}
		DocumentMetadataHeadManager serviceNotNull = Locator.GetServiceNotNull<DocumentMetadataHeadManager>();
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
		Guid documentTypeUid = Guid.Empty;
		if (propValues.ContainsKey("DocumentTypeUid") && propValues["DocumentTypeUid"] != null)
		{
			Guid.TryParse(propValues["DocumentTypeUid"].ToString(), out documentTypeUid);
		}
		if (documentTypeUid == Guid.Empty)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T("Не выполнены правила импорта: свойство TypeUid импортируемого объекта - пустое")));
			return false;
		}
		List<IDocumentMetadataHead> list = serviceNotNull.Find((IDocumentMetadataHead h) => h.DocumentTypeUid == documentTypeUid).ToList();
		if (list != null && list.Count != 0 && list[0] != null)
		{
			IDocumentMetadataHead documentMetadataHead = list[0];
			if (result != documentMetadataHead.Uid)
			{
				propValues["Uid"] = documentMetadataHead.Uid.ToString();
			}
		}
		return true;
	}

	private void GenerateNewName(List<IDocumentMetadataGroup> newGroupsForThisParent, List<IDocumentMetadataGroup> allGroupsForThisParent)
	{
		foreach (IDocumentMetadataGroup item in newGroupsForThisParent)
		{
			IDocumentMetadataGroup groupF = item;
			string name = groupF.Name;
			IEnumerable<IDocumentMetadataGroup> enumerable = allGroupsForThisParent.Where((IDocumentMetadataGroup g) => g.Uid != groupF.Uid && string.Equals(g.Name, groupF.Name, StringComparison.OrdinalIgnoreCase));
			long num = 1L;
			while (enumerable != null && enumerable.Any() && num < long.MaxValue)
			{
				string newName = $"{((name.Length + num.ToString().Length + 3 > 2000) ? name.Substring(1, 2000 - num.ToString().Length - 3) : name)} ({num})";
				enumerable = allGroupsForThisParent.Where((IDocumentMetadataGroup g) => g.Uid != groupF.Uid && string.Equals(g.Name, newName, StringComparison.OrdinalIgnoreCase));
				if (enumerable == null || !enumerable.Any() || num >= long.MaxValue)
				{
					groupF.Name = newName;
				}
				num++;
			}
		}
	}

	private void CreateDocumentGroup(IDocumentMetadataGroup group, List<IDocumentMetadataGroup> newGroups, Dictionary<string, string> serviceData)
	{
		if (group.ParentGroup != null && !group.ParentGroup.IsDeleted)
		{
			return;
		}
		string subKey = $"DocumentGroupForDocumentGroup_{group.Uid.ToString().ToLower()}_";
		string text = serviceData.Keys.FirstOrDefault((string s) => s.StartsWith(subKey));
		if (string.IsNullOrWhiteSpace(text) || !serviceData.ContainsKey(text))
		{
			return;
		}
		string[] array = text.Split('_');
		if (array.Count() != 3 || !Guid.TryParse(array[2], out var parentGroupUid) || !(parentGroupUid != Guid.Empty) || newGroups.FirstOrDefault((IDocumentMetadataGroup g) => g.Uid == parentGroupUid) != null)
		{
			return;
		}
		IDocumentMetadataGroup documentMetadataGroup = Locator.GetServiceNotNull<DocumentMetadataGroupManager>().LoadOrNull(parentGroupUid);
		if (documentMetadataGroup != null && !documentMetadataGroup.IsNew())
		{
			group.ParentGroup = (documentMetadataGroup.IsDeleted ? DocumentMetadataGroupManager.Instance.LoadOrNull(DocumentConstants.RootDocumentFolderUid) : documentMetadataGroup);
			return;
		}
		if (documentMetadataGroup == null)
		{
			documentMetadataGroup = InterfaceActivator.Create<IDocumentMetadataGroup>();
			documentMetadataGroup.Uid = parentGroupUid;
		}
		documentMetadataGroup.Name = serviceData[text];
		documentMetadataGroup.Save();
		group.ParentGroup = documentMetadataGroup;
		newGroups.Add(documentMetadataGroup);
		CreateDocumentGroup(documentMetadataGroup, newGroups, serviceData);
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		if (!(entity is IDocumentMetadataHead documentMetadataHead))
		{
			return new List<TestImportMessages>
			{
				new TestImportMessages(TestImportMessagesType.Error, SR.T("Не выполнено правило экспорта-импорта для заголовка метаданных документа (DocumentMetadataHead): заголовок не найден"))
			};
		}
		try
		{
			if (documentMetadataHead.Group == null || documentMetadataHead.Group.IsDeleted)
			{
				List<IDocumentMetadataGroup> list = new List<IDocumentMetadataGroup>();
				string subKey = $"{DocumentsExportConsts.DocumentGroupForDocumentHeaderKey}{documentMetadataHead.Uid.ToString().ToLower()}_";
				string text = data.ServiceData.Keys.FirstOrDefault((string s) => s.StartsWith(subKey));
				if (!string.IsNullOrWhiteSpace(text) && data.ServiceData.ContainsKey(text))
				{
					string[] array = text.Split('_');
					if (array.Count() == 3 && Guid.TryParse(array[2], out var result) && result != Guid.Empty)
					{
						IDocumentMetadataGroup documentMetadataGroup = Locator.GetServiceNotNull<DocumentMetadataGroupManager>().LoadOrNull(result);
						if (documentMetadataGroup != null && !documentMetadataGroup.IsNew())
						{
							documentMetadataHead.Group = (documentMetadataGroup.IsDeleted ? DocumentMetadataGroupManager.Instance.LoadOrNull(DocumentConstants.RootDocumentFolderUid) : documentMetadataGroup);
						}
						else
						{
							if (documentMetadataGroup == null)
							{
								documentMetadataGroup = InterfaceActivator.Create<IDocumentMetadataGroup>();
								documentMetadataGroup.Uid = result;
							}
							documentMetadataGroup.Name = data.ServiceData[text];
							documentMetadataGroup.Save();
							documentMetadataHead.Group = documentMetadataGroup;
							list.Add(documentMetadataGroup);
							CreateDocumentGroup(documentMetadataGroup, list, data.ServiceData);
						}
					}
				}
				if (list.Any())
				{
					foreach (IDocumentMetadataGroup item in (from g in list
						where g.ParentGroup != null
						select g.ParentGroup).Distinct())
					{
						IDocumentMetadataGroup parentGroupF = item;
						List<IDocumentMetadataGroup> list2 = list.Where((IDocumentMetadataGroup g) => g.ParentGroup != null && g.ParentGroup.Uid == parentGroupF.Uid).ToList();
						List<IDocumentMetadataGroup> list3 = new List<IDocumentMetadataGroup>();
						list3.AddRange(list2);
						if (item.Groups != null)
						{
							list3.AddRange((IEnumerable<IDocumentMetadataGroup>)parentGroupF.Groups);
						}
						GenerateNewName(list2, list3);
					}
				}
			}
		}
		catch (Exception exception)
		{
			ImportLog.Info("CreateDocumentGroupError. For DocumentHeader " + documentMetadataHead.Uid, exception);
		}
		if (documentMetadataHead.Group == null || documentMetadataHead.Group.Uid == DocumentConstants.RecycleDocumentFolderUid)
		{
			IDocumentMetadataGroup documentMetadataGroup2 = DocumentMetadataGroupManager.Instance.LoadOrNull(DocumentConstants.RootDocumentFolderUid);
			if (documentMetadataGroup2 == null)
			{
				return new List<TestImportMessages>
				{
					new TestImportMessages(TestImportMessagesType.Error, SR.T("Не выполнено правило экспорта-импорта для заголовка метаданных документа (DocumentMetadataHead): не найдена корневая папка метаданных документов"))
				};
			}
			documentMetadataHead.Group = documentMetadataGroup2;
		}
		return new List<TestImportMessages>();
	}
}

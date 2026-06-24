using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.DTO.Managers;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Extensions;

[Component]
internal class NullifierActionsDocumentExtension : INullifierActions
{
	private static readonly Guid uidDocuments = new Guid("127200A9-BCA3-4112-8B9A-9579FAA47C86");

	private static readonly Guid uidTypeDocuments = new Guid("4E15F0C6-F594-4bb5-BB3F-849E2951B09E");

	private static readonly Guid uidFolderDocuments = new Guid("E003F6A9-CEFE-4392-8BF4-78F7E680659E");

	private static readonly Guid uidDocumentTask = new Guid("71c8fc8b-be49-49b6-80ad-a00b5654e6b4");

	private static readonly Guid uidDocumentTaskItem = new Guid("2d44e267-0a2b-4307-be3d-dec11f584c99");

	private string tempTableNameFolder = "";

	private string tempTableNameDms = "";

	private string tempTableName = "";

	private ClearObjectParameters ClearObjectParams;

	private Func<string, Guid, object, int, string, Guid, bool, bool, Image, bool> AddNode;

	private IEnumerable<FolderTreeNode> allNodes;

	private int TempTableNameFolderCount;

	private int TempTableNameDmsCount;

	protected IDocumentMetadataGroupDTOManager Manager => Locator.GetServiceNotNull<IDocumentMetadataGroupDTOManager>();

	public void CreateTree(Func<string, Guid, object, int, string, Guid, bool, bool, Image, bool> addNode)
	{
		AddNode = addNode;
		addNode(SR.T("Документооборот"), uidDocuments, uidDocuments, 0, null, Guid.Empty, arg7: false, arg8: false, null);
		addNode(SR.T("Типы документов"), uidDocuments, uidTypeDocuments, 1, null, Guid.Empty, arg7: false, arg8: false, null);
		DocumentMetadataGroupDTO documentMetadataGroupDTO = Manager.LoadRootGroup(new Guid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}"));
		addNode(documentMetadataGroupDTO.Name, documentMetadataGroupDTO.Uid, documentMetadataGroupDTO, 1, null, Guid.Empty, arg7: false, arg8: false, null);
		FillChildNodes(documentMetadataGroupDTO);
		AddNode(null, Guid.Empty, null, -1, null, Guid.Empty, arg7: false, arg8: false, null);
		addNode(SR.T("Папки с документами"), uidFolderDocuments, uidFolderDocuments, 1, null, Guid.Empty, arg7: false, arg8: false, null);
		FolderTree();
	}

	private void FolderTree()
	{
		allNodes = FolderManager.Instance.LoadTreeAll();
		FillChildNodes();
	}

	private void FillChildNodes(long? folderRoot = null)
	{
		int num = 0;
		foreach (FolderTreeNode allNode in allNodes)
		{
			try
			{
				if (folderRoot == allNode.FolderId)
				{
					string arg = allNode.Name + ((!allNode.FolderId.HasValue) ? $" ({UserManager.Instance.Load(allNode.CreationAuthor).FullName})" : "");
					IFolder folder = FolderManager.Instance.LoadOrNull(allNode.Id);
					AddNode(arg, folder.Uid, folder, (num == 0) ? 1 : 0, SR.T("Очистить папку"), uidFolderDocuments, arg7: false, arg8: false, null);
					FillChildNodes(allNode.Id);
					num++;
				}
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Ошибка загрузки папки документа"), exception);
			}
		}
		if (num > 0)
		{
			AddNode(null, Guid.Empty, null, -1, null, Guid.Empty, arg7: false, arg8: false, null);
		}
	}

	private bool FillChildNodes(DocumentMetadataGroupDTO group)
	{
		foreach (DocumentMetadataGroupDTO item in group.Groups.OrderBy((DocumentMetadataGroupDTO g) => g.Name))
		{
			AddNode(item.Name, item.Uid, item, 1, null, uidTypeDocuments, arg7: false, arg8: false, null);
			FillChildNodes(item);
		}
		IEnumerable<IMetadata> metadataList = MetadataServiceContext.Service.GetMetadataList();
		int num = 0;
		foreach (DocumentMetadataHeadDTO docType in group.DocumentTypes)
		{
			if (docType != null && docType.GroupId == group.Id)
			{
				if (metadataList.FirstOrDefault((IMetadata w) => w.Uid == docType.DocumentTypeUid) is EntityMetadata entityMetadata)
				{
					AddNode(entityMetadata.DisplayName, entityMetadata.Uid, entityMetadata, (num == 0) ? 1 : 0, SR.T("Удалить документы"), uidTypeDocuments, arg7: false, arg8: false, null);
				}
				num++;
			}
		}
		if (num > 0)
		{
			AddNode(null, Guid.Empty, null, -1, null, Guid.Empty, arg7: false, arg8: false, null);
		}
		AddNode(null, Guid.Empty, null, -1, null, Guid.Empty, arg7: false, arg8: false, null);
		return true;
	}

	public void ClearObject(ClearObjectParameters clearObjectParameters)
	{
		ClearObjectParams = clearObjectParameters;
		tempTableNameFolder = ClearObjectParams.Transform.Dialect.QuoteIfNeeded("nulltemptableoneFolder");
		tempTableName = ClearObjectParams.Transform.Dialect.QuoteIfNeeded("nulltemptable");
		foreach (UnitNullConfig unit in ClearObjectParams.units)
		{
			if (unit.TypeUid == uidFolderDocuments)
			{
				ClearObjectParams.DeleteFolder(unit.Uid, 0, arg3: true);
			}
			else if (unit.TypeUid == uidTypeDocuments)
			{
				DeleteTypeDocument(unit);
			}
		}
	}

	public DeleteFoldersOutput DeleteFolders(DeleteFoldersInput deleteFoldersInput)
	{
		if (ClearObjectParams == null)
		{
			ClearObjectParams = new ClearObjectParameters
			{
				Transform = deleteFoldersInput.transform,
				SqlQuery = deleteFoldersInput.sqlQuery
			};
		}
		TempTableNameFolderCount = 0;
		TempTableNameDmsCount = 0;
		DeleteFolder(deleteFoldersInput.uid, deleteFoldersInput.level, deleteFoldersInput.ClearFolderOnly);
		return new DeleteFoldersOutput
		{
			tempTableNameDmsCount = TempTableNameDmsCount,
			tempTableNameFolderCount = TempTableNameFolderCount
		};
	}

	private void DeleteTypeDocument(UnitNullConfig unit)
	{
		UnitNullConfigDocument unitNullConfigDocument = unit as UnitNullConfigDocument;
		string text = "";
		string text2 = Condition(unitNullConfigDocument);
		EntityMetadata entityMetadata = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(unitNullConfigDocument.Uid);
		string text3 = (text2.IsNullOrEmpty() ? "" : string.Format("and f.{1} in (select {1} from {0} where {2} )", ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), text2));
		EntityMetadata entityMetadata2 = (EntityMetadata)InterfaceActivator.LoadMetadata<IDmsObject>(inherit: true, loadImplementation: false);
		EntityMetadata entityMetadata3 = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocumentVersion>(inherit: true, loadImplementation: false);
		EntityMetadata entityMetadata4 = (EntityMetadata)InterfaceActivator.LoadMetadata<IEntityActionHistory>(inherit: true, loadImplementation: false);
		if (unitNullConfigDocument.CheckDeleteVersionDocument)
		{
			if (unitNullConfigDocument.CheckDeleteActivVersionDocument)
			{
				text = string.Format("select dv.{1} from {6} dv join {3} dobj on dobj.{1}=dv.{2} join {5} d on  dobj.{1}=d.{1} join {0} f on  dobj.{1}=f.{1} where dv.{1}!=d.{4} {7}", ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("DocumentId"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata2.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("CurrentVersion"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Document"), entityMetadata3.TableName, text3);
			}
			if (unitNullConfigDocument.CheckDeleteDateVersionDocument)
			{
				if (unitNullConfigDocument.CheckExactDateVersionDocument)
				{
					text = string.Format("select dv.{1} from {6} dv join {3} dobj on dobj.{1}=dv.{2} join {5} d on  dobj.{1}=d.{1} join {0} f on  dobj.{1}=f.{1} and dv.{7} < {8} {9}", ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("DocumentId"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata2.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("CurrentVersion"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Document"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata3.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("CreationDate"), ClearObjectParams.Transform.Dialect.DateToSql(unitNullConfigDocument.ExactDateVersionDocument.HasValue ? unitNullConfigDocument.ExactDateVersionDocument.Value : DateTime.MinValue), text3);
				}
				if (unitNullConfigDocument.CheckRelativeDateVersionDocument)
				{
					DateTime now = DateTime.Now;
					int num = (int)(unitNullConfigDocument.CheckRelativeDateVersionDocumentYear.HasValue ? unitNullConfigDocument.CheckRelativeDateVersionDocumentYear.Value : 0);
					int num2 = (int)(unitNullConfigDocument.CheckRelativeDateVersionDocumentMonth.HasValue ? unitNullConfigDocument.CheckRelativeDateVersionDocumentMonth.Value : 0);
					int num3 = (int)(unitNullConfigDocument.CheckRelativeDateVersionDocumentDay.HasValue ? unitNullConfigDocument.CheckRelativeDateVersionDocumentDay.Value : 0);
					now = now.AddYears(num * -1).AddMonths(num2 * -1).AddDays(num3 * -1);
					text = string.Format("select dv.{1} from {6} dv join {3} dobj on dobj.{1}=dv.{2} join {5} d on  dobj.{1}=d.{1} join {0} f on  dobj.{1}=f.{1} and dv.{7} < {8} {9}", ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("DocumentId"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata2.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("CurrentVersion"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Document"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata3.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("CreationDate"), ClearObjectParams.Transform.Dialect.DateToSql(now), text3);
				}
			}
			if (unitNullConfigDocument.DeleteHistoryVersionDocument)
			{
				ClearObjectParams.AddLog(SR.T("Удаляем истрию версий документов"));
				ClearObjectParams.SqlQuery(string.Format("delete  from {0} where  {2} in (select e.{2} from  {0} e  where  exists  (select 1 from {1} t where e.{5}=t.{6} and   e.{7}=t.{2} and t.{2} in ({4})))", ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata4.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata3.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), "", text, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("ActionObjectUid"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("TypeUid"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("ActionObjectId")), SR.T("-73- Удалить истрию версий документов"));
			}
			ClearObjectParams.DeleteEntityMetadataUnit(new UnitNullConfig
			{
				Uid = InterfaceActivator.UID<IDocumentVersion>(loadImplementation: false)
			}, text, arg3: false, 0, arg5: false);
		}
		else
		{
			text = string.Format("select dv.{1} from {6} dv join {3} dobj on dobj.{1}=dv.{2} join {5} d on  dobj.{1}=d.{1} join {0} f on  dobj.{1}=f.{1} {7} ", ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("DocumentId"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("CurrentVersion"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Document"), entityMetadata3.TableName, text3);
			ClearObjectParams.DeleteEntityMetadataUnit(new UnitNullConfig
			{
				Uid = InterfaceActivator.UID<IDocumentVersion>(loadImplementation: false)
			}, text, arg3: false, 0, arg5: false);
			ClearObjectParams.AddLog(SR.T("Удаляем истрию версий документов"));
			ClearObjectParams.SqlQuery(string.Format("delete  from {0} where  {2} in (select e.{2} from  {0} e  where  exists  (select 1 from {1} t where e.{5}=t.{6} and   e.{7}=t.{2} and t.{2} in ({4})))", entityMetadata4.TableName, entityMetadata3.TableName, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), "", text, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("ActionObjectUid"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("TypeUid"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("ActionObjectId")), SR.T("-71- Удалить истрию версий документов"));
			ClearObjectParams.DeleteEntityMetadataUnit(new UnitNullConfig
			{
				Uid = InterfaceActivator.UID<IDocumentVersion>(loadImplementation: false)
			}, text, arg3: false, 0, arg5: false);
			ClearObjectParams.AddLog(SR.T("Удаляем весь выбранный тип документов"));
			string text4 = string.Format("select {1} from {2} {0}", text2.IsNullOrEmpty() ? "" : $"where {text2}", ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata.TableName));
			ClearObjectParams.AddLog(SR.T("Удалить истрию документов"));
			ClearObjectParams.SqlQuery(string.Format("delete  from {0} where  {2} in (select e.{2} from  {0} e  where  exists  (select 1 from {1} t where    e.{5}=t.{6} and  e.{7}=t.{2} and t.{2} in ({4})))", ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata4.TableName), entityMetadata2.TableName, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), "", text4, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("ActionObjectUid"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("TypeUid"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("ActionObjectId")), SR.T("-72- Удалить историю  документов"));
			EntityMetadata entityMetadata5 = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocumentAttachment>(inherit: true, loadImplementation: false);
			string arg = string.Format("select {3} from {2} where {1} in ({0} )", text4, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Document"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata5.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"));
			ClearObjectParams.DeleteEntityMetadataUnit(new UnitNullConfig
			{
				Uid = InterfaceActivator.UID<IDocumentAttachment>(loadImplementation: false)
			}, arg, arg3: false, 0, arg5: false);
			ClearObjectParams.ExecuteQuery($"delete from {tempTableName}", SR.T("-16- Удаляем временную таблицу "));
			string text5 = string.Format("select a.{1} from {2} a where a.{0} in ({3})", ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Document"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("DocumentTaskItem"), text4);
			ClearObjectParams.ExecuteQuery(string.Format("insert into {6} ({0}) select {0} from {4} a left join {3} sm on sm.{2} in ({5}) where a.{0}=sm.{1}", ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("TaskId"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("ItemId"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("M_DocumentTask_Elementy"), ClearObjectParams.Transform.Dialect.QuoteIfNeeded("DocumentTask"), text5, tempTableName), SR.T("Удаляемые задачи по документу"));
			ClearObjectParams.DeleteEntityMetadataUnit(new UnitNullConfig
			{
				Uid = uidDocumentTaskItem,
				Action = 0
			}, text5, arg3: false, 0, arg5: false);
			string arg2 = string.Format("select {1} from {0} ", tempTableName, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"));
			ClearObjectParams.DeleteEntityMetadataUnit(new UnitNullConfig
			{
				Uid = uidDocumentTask,
				Action = 0
			}, arg2, arg3: false, 0, arg5: false);
			ClearObjectParams.ExecuteQuery($"delete from  {tempTableName}", SR.T("-16- Удаляем временную таблицу "));
			ClearObjectParams.DeleteEntityMetadataUnit(unitNullConfigDocument, text4, arg3: false, 0, arg5: false);
		}
	}

	public void PostNullifier(PostNullifierParameters postNullifierParameters)
	{
		if (postNullifierParameters.TempTableNameDmsCount > 0)
		{
			string arg = string.Format("select {1} from {0}", tempTableNameDms, postNullifierParameters.Transform.Dialect.QuoteIfNeeded("Id"));
			postNullifierParameters.DeleteEntityMetadata(new UnitNullConfig
			{
				Uid = InterfaceActivator.UID<IDmsObject>(loadImplementation: false)
			}, arg, arg3: false, 0, arg5: false);
		}
		if (postNullifierParameters.TempTableNameFolderCount > 0)
		{
			string arg2 = string.Format("select {1} from {0}", tempTableNameFolder, postNullifierParameters.Transform.Dialect.QuoteIfNeeded("Id"));
			postNullifierParameters.DeleteEntityMetadata(new UnitNullConfig
			{
				Uid = InterfaceActivator.UID<IFolder>(loadImplementation: false)
			}, arg2, arg3: false, 0, arg5: false);
		}
	}

	public void SearchSystemFile()
	{
	}

	public void DeleteFolder(Guid uid, int level, bool ClearFolderOnly)
	{
		tempTableNameDms = ClearObjectParams.Transform.Dialect.QuoteIfNeeded("nulltemptableDms");
		tempTableNameFolder = ClearObjectParams.Transform.Dialect.QuoteIfNeeded("nulltemptableoneFolder");
		level++;
		try
		{
			IFolder folder = FolderManager.Instance.LoadOrNull(uid);
			if (folder != null)
			{
				ClearObjectParams.SqlQuery(null, string.Format(SR.T("Очистка папки с докумнтами '{0}'."), folder));
				if (uid == DocumentConstants.ArchiveFolderUid)
				{
					TempTableNameDmsCount++;
					ClearObjectParams.SqlQuery(string.Format("insert into {0}({1}) select {1} from {2} where {3}=1", tempTableNameDms, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), ((EntityMetadata)InterfaceActivator.LoadMetadata<IDmsObject>(inherit: true, loadImplementation: false)).TableName, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("IsArchived")), SR.T("-9- Заполнение временной таблицы"));
				}
				else
				{
					TempTableNameDmsCount++;
					ClearObjectParams.SqlQuery(string.Format("insert into  {0}({1})select d.{1} from {2} d left join {3} f on d.{1}=f.{1}  where {3}={4} and f.{1} is null", tempTableNameDms, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), ((EntityMetadata)InterfaceActivator.LoadMetadata<IDmsObject>(inherit: true, loadImplementation: false)).TableName, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Folder"), folder.Id), SR.T("-9- Заполнение временной таблицы"));
				}
				if (!ClearFolderOnly)
				{
					TempTableNameFolderCount++;
					ClearObjectParams.SqlQuery(string.Format("insert into  {0}({1})values({2})", tempTableNameFolder, ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), folder.Id), SR.T("-9- Заполнение временной таблицы"));
				}
			}
		}
		catch (Exception ex)
		{
			string text = SR.T("Ошибка при удалении папаки: {0}", ex.Message);
			ClearObjectParams.AddLog(text);
			Logger.Log.Error(text, ex);
		}
	}

	private string Condition(UnitNullConfig unit)
	{
		string text = "";
		if (unit.UseAdditionalParams)
		{
			if (unit.UseIdBetweenParams)
			{
				if (unit.InstanceIdFrom.HasValue && unit.InstanceIdTo.HasValue)
				{
					if (Convert.ToInt64(unit.InstanceIdFrom) >= 0 && Convert.ToInt64(unit.InstanceIdTo) >= 0)
					{
						if (text != string.Empty)
						{
							text += " and ";
						}
						text += string.Format("{0} between {1} and {2}   ", ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), unit.InstanceIdFrom, unit.InstanceIdTo);
					}
				}
				else if (!unit.InstanceIdFrom.HasValue && unit.InstanceIdTo.HasValue)
				{
					if (Convert.ToInt64(unit.InstanceIdTo) >= 0)
					{
						if (text != string.Empty)
						{
							text += " and ";
						}
						text += string.Format("{0} <={1} ", ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), unit.InstanceIdTo);
					}
				}
				else if (unit.InstanceIdFrom.HasValue && !unit.InstanceIdTo.HasValue)
				{
					if (text != string.Empty)
					{
						text += " and ";
					}
					text += string.Format("{0} >={1} ", ClearObjectParams.Transform.Dialect.QuoteIfNeeded("Id"), unit.InstanceIdFrom);
				}
			}
			if (!string.IsNullOrEmpty(unit.AdditionalSqlText))
			{
				text += ((!string.IsNullOrEmpty(text)) ? " and " : "");
				text += unit.AdditionalSqlText;
			}
		}
		return text;
	}
}

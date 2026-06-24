using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Common.BulkDataImport.Handlers;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using NHibernate;

namespace EleWise.ELMA.Documents.ExtensionPoint;

public class DmsObjectBulkDataImportHandler : IBulkDataImportHandler
{
	protected readonly long BulkInsertLimit = 50000L;

	protected readonly string CreationAutorPropertyName = InterfaceActivator.PropertyName((IDmsObject o) => o.CreationAuthor);

	protected readonly string IdPropertyName = "Id";

	protected readonly string DmsObjectPermissionTableName = "DmsObjectPermission";

	private ISession session;

	private List<Type> typesForCleanUp = new List<Type> { typeof(IDmsObject) };

	public DocumentManager DocumentManager { get; set; }

	public FolderManager FolderManager { get; set; }

	public DmsObjectManager DmsObjectManager { get; set; }

	public ISessionProvider SessionProvider { get; set; }

	public ITransformationProvider Transformation { get; set; }

	protected ISession Session => session ?? (session = SessionProvider.GetSession(""));

	public virtual bool CanUse(Type type)
	{
		return typeof(IDmsObject).IsAssignableFrom(type);
	}

	public virtual void AfterImport(BulkDataImportHandlerData handlerData)
	{
		foreach (IFolder item in FolderManager.GetRootsAll())
		{
			DmsObjectManager.UpdatePermissions(item);
		}
		Session.CleanUpCache(typesForCleanUp.ToArray());
	}

	public virtual void AfterImportPage(IEnumerable<MapInfo> mapInfos, BulkDataImportHandlerData handlerData)
	{
		IEnumerable<Tuple<long, long>> idList = GetIdList(mapInfos, typeof(IDmsObject));
		if (idList.Any())
		{
			ExecuteInsertPermissions(idList, GetDefaultPermissionGuidList(), GetDmsObjectPermissionTable());
		}
	}

	public void AddTypeForCleanUp(Type type)
	{
		typesForCleanUp.Add(type);
	}

	public virtual void BeforeMapping(DataTable data, BulkDataImportHandlerData handlerData)
	{
	}

	protected List<Guid> GetDefaultPermissionGuidList()
	{
		return new List<Guid>
		{
			PermissionProvider.DocumentViewPermission.Id,
			PermissionProvider.DocumentLoadPermission.Id,
			PermissionProvider.DocumentEditPermission.Id,
			PermissionProvider.DocumentManagerAccessPermission.Id,
			PermissionProvider.DocumentFullAccessPermission.Id
		};
	}

	protected DataTable GetDmsObjectPermissionTable()
	{
		return new DataTable(DmsObjectPermissionTableName)
		{
			Columns = 
			{
				{
					"Id",
					typeof(long)
				},
				{
					"Uid",
					typeof(Guid)
				},
				{
					"DmsObject",
					typeof(long)
				},
				{
					"PermissionId",
					typeof(Guid)
				},
				{
					"User",
					typeof(long)
				},
				{
					"Group",
					typeof(long)
				},
				{
					"OrganizationItemPosition",
					typeof(long)
				},
				{
					"UserSecuritySetCacheId",
					typeof(long)
				},
				{
					"PermissionRole",
					typeof(Guid)
				},
				{
					"InheritedFromFolder",
					typeof(long)
				}
			}
		};
	}

	protected void ExecuteInsertPermissions(IEnumerable<Tuple<long, long>> idList, IEnumerable<Guid> permList, DataTable table)
	{
		foreach (Tuple<long, long> id in idList)
		{
			foreach (Guid perm in permList)
			{
				DataRow dataRow = table.NewRow();
				dataRow["Uid"] = Guid.NewGuid();
				dataRow["DmsObject"] = id.Item2;
				dataRow["PermissionId"] = perm;
				dataRow["PermissionRole"] = CommonRoleTypes.Author.Id;
				dataRow["User"] = id.Item1;
				table.Rows.Add(dataRow);
				if (table.Rows.Count >= BulkInsertLimit)
				{
					Transformation.BulkInsert(DmsObjectPermissionTableName, table);
					table.Clear();
				}
			}
		}
		if (table.Rows.Count > 0)
		{
			Transformation.BulkInsert(DmsObjectPermissionTableName, table);
			table.Clear();
		}
	}

	protected IEnumerable<Tuple<long, long>> GetIdList(IEnumerable<MapInfo> mapInfos, Type assignType, bool skipDocumentIds = true)
	{
		List<ImportObject> list = new List<ImportObject>();
		IEnumerable<MapInfo> enumerable = mapInfos.Where((MapInfo inf) => assignType.IsAssignableFrom(inf.ObjectType));
		if (skipDocumentIds)
		{
			enumerable = enumerable.Where((MapInfo info) => !typeof(IDocument).IsAssignableFrom(info.ObjectType));
		}
		foreach (MapInfo item in enumerable)
		{
			if (item.Objects != null)
			{
				list.AddRange(item.Objects);
			}
		}
		List<Tuple<long, long>> list2 = new List<Tuple<long, long>>();
		foreach (ImportObject item2 in list)
		{
			ObjectId objectId = null;
			ObjectId objectId2 = null;
			bool flag = false;
			foreach (PropertyValue value in item2.Values)
			{
				if (value.Columns == null)
				{
					continue;
				}
				if (value.PropertyInfo.Name == CreationAutorPropertyName)
				{
					objectId = value.Columns.FirstOrDefault((KeyValuePair<string, object> c) => c.Value is ObjectId).Value as ObjectId;
				}
				if (value.PropertyInfo.Name == IdPropertyName)
				{
					objectId2 = value.Columns.FirstOrDefault((KeyValuePair<string, object> c) => c.Value is ObjectId).Value as ObjectId;
				}
				flag = objectId2 != null && objectId != null;
				if (flag)
				{
					break;
				}
			}
			if (flag)
			{
				list2.Add(new Tuple<long, long>((long)objectId.Id, (long)objectId2.Id));
			}
		}
		return list2;
	}
}

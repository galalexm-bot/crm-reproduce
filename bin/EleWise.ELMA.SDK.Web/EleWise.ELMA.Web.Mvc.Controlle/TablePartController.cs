using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.DynamicForms;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.TableParts;
using EleWise.ELMA.Web.Mvc.Util;
using Iesi.Collections;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Persister.Entity;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.Infrastructure;
using Telerik.Web.Mvc.UI.Fluent;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class TablePartController : BaseController
{
	public class TablePartRequestData
	{
		public GridCommand command { get; set; }

		public Guid uid { get; set; }

		public string parentDataObjectId { get; set; }

		public string parentDataMetadataUid { get; set; }

		public string gridId { get; set; }

		public string gridStateId { get; set; }

		public string jsonDataHiddenFieldId { get; set; }

		public string parentDataHiddenFieldId { get; set; }

		public string itemPath { get; set; }

		public string jsonData { get; set; }

		public string parentRootJsonData { get; set; }

		public string editingItem_id { get; set; }

		public bool editInPopUp { get; set; }

		public string viewProviderUid { get; set; }

		public string viewItemId { get; set; }

		public Guid? viewItemUid { get; set; }

		public string dynamicFormsProviderUid { get; set; }

		public string dynamicFormsProviderData { get; set; }

		public string parentFormId { get; set; }

		public bool readOnly { get; set; }

		public bool fullReadOnly { get; set; }

		public bool showEditorsDescription { get; set; }

		public long lastTemporaryId
		{
			get
			{
				return GetLastTemporaryId();
			}
			set
			{
				if (value != 0L && value < GetLastTemporaryId())
				{
					SetLastTemporaryId(value);
				}
			}
		}
	}

	private class TablePartData
	{
		public TablePartRequestData Data { get; set; }

		public IEnumerable OriginalItems { get; set; }

		public IEnumerable Items { get; set; }

		public List<object> DeletedItemsIds { get; set; }

		public object JsonData { get; set; }

		public ViewItemTransformation ViewItemTransformation { get; set; }

		public TablePartChangesModel OriginalChangesModel { get; set; }

		public TableView TableView { get; set; }

		public RootViewItem EditingItemView { get; set; }

		public DynamicFormSettings DynamicFormSettings { get; set; }

		public bool ProcessDynamicForm { get; set; }

		public IEntity Parent { get; set; }

		public ISet TablePartValues { get; set; }

		public ActionResult DynamicFormResult { get; set; }

		public TablePartData(TablePartRequestData data, IEnumerable originalItems, List<IEntity> items)
		{
			Data = data;
			OriginalItems = originalItems;
			Items = items;
			DeletedItemsIds = new List<object>();
		}

		public void InitJsonData()
		{
			JsonData = ItemsToJsonData();
		}

		private object ItemsToJsonData()
		{
			if (Items == null)
			{
				return null;
			}
			TablePartChangesModel tablePartChangesModel = new TablePartChangesModel(Items, OriginalItems)
			{
				TotalCount = ((Items != null) ? Items.OfType<object>().Count() : 0)
			};
			foreach (IEntity deletedEntity in tablePartChangesModel.DeletedEntities)
			{
				Locator.GetServiceNotNull<IUnitOfWorkManager>().RevertEntityChangesOnCommit("", deletedEntity);
			}
			foreach (object deletedItemsId in DeletedItemsIds)
			{
				if (!tablePartChangesModel.Deleted.Contains(deletedItemsId.ToString()))
				{
					tablePartChangesModel.Deleted.Add(deletedItemsId.ToString());
				}
			}
			if (OriginalChangesModel != null)
			{
				foreach (string item in OriginalChangesModel.Deleted)
				{
					if (!tablePartChangesModel.Deleted.Contains(item.ToString()))
					{
						tablePartChangesModel.Deleted.Add(item.ToString());
					}
				}
			}
			return tablePartChangesModel.ToDictionary();
		}
	}

	private class PropertyInfo
	{
		public Guid PropertyUid { get; set; }

		public bool IsTablePart { get; set; }

		public IPropertyMetadata Metadata { get; set; }

		public PropertyViewItem ViewItem { get; set; }
	}

	private static ISessionProvider sessionProvider;

	public IMetadataRuntimeService IMetadataRuntimeService { get; set; }

	public IContextBoundVariableService ContextService { get; set; }

	private static ISessionProvider SessionProvider => sessionProvider ?? (sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());

	private static bool HaveOriginalState(IEntity item, IEntityMetadata metadata)
	{
		ISession session = SessionProvider.GetSession("");
		EntityMetadata entityMetadata = metadata as EntityMetadata;
		if (entityMetadata == null)
		{
			entityMetadata = MetadataLoader.LoadMetadata(item.GetType()) as EntityMetadata;
		}
		if (entityMetadata == null || string.IsNullOrWhiteSpace(entityMetadata.TableName))
		{
			return false;
		}
		IEntityPersister entityPersister = session.GetEntityPersister(item);
		return session.GetSessionImplementation().get_PersistenceContext().GetDatabaseSnapshot(entityPersister.GetIdentifier((object)item), entityPersister) != null;
	}

	private static void RevertNewItemsIds(IEnumerable items, ITablePartMetadata metadata, bool recursive = true)
	{
		if (items == null)
		{
			return;
		}
		IEnumerable<IEntity> enumerable = items.OfType<IEntity>();
		if (enumerable.Count() <= 0)
		{
			return;
		}
		ITablePartContainer tablePartContainer = metadata as ITablePartContainer;
		if (tablePartContainer == null)
		{
			tablePartContainer = MetadataLoader.LoadMetadata(enumerable.ElementAt(0).GetType()) as ITablePartContainer;
		}
		foreach (IEntity item in enumerable)
		{
			object id = item.GetId();
			Type type = item.GetType();
			Type entityIdType = ModelHelper.GetEntityIdType(type);
			if (type.IsDefaultId(entityIdType, id))
			{
				item.SetId(GetNextTemporaryId());
			}
			else
			{
				if (type.IsNewId(entityIdType, id) || !(metadata is EntityMetadata entityMetadata) || string.IsNullOrWhiteSpace(entityMetadata.TableName) || !recursive || tablePartContainer == null)
				{
					continue;
				}
				if (!HaveOriginalState(item, (IEntityMetadata)tablePartContainer))
				{
					item.SetId(GetNextTemporaryId());
				}
				foreach (ITablePartMetadata tablePart in tablePartContainer.TableParts)
				{
					RevertNewItemsIds(item.GetPropertyValue(tablePart.TablePartPropertyUid) as IEnumerable, null);
				}
			}
		}
	}

	public static IEnumerable<KeyValuePair<ITablePartMetadata, PropertyViewItem>> GetOrderedTableParts(ITablePartMetadata metadata, RootViewItem view)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		List<ITablePartMetadata> tableParts = ((IEntityMetadata)metadata).GetPropertiesAndTableParts().OfType<ITablePartMetadata>().ToList();
		if (view == null)
		{
			return tableParts.Select((ITablePartMetadata m) => new KeyValuePair<ITablePartMetadata, PropertyViewItem>(m, null)).ToList();
		}
		return (from item in view.GetAllItems().OfType<PropertyViewItem>()
			select new
			{
				item = item,
				tp = tableParts.FirstOrDefault((ITablePartMetadata t) => t.TablePartPropertyUid == item.PropertyUid)
			} into t
			where t.tp != null
			select new KeyValuePair<ITablePartMetadata, PropertyViewItem>(t.tp, t.item)).ToList();
	}

	public static string GetInitialJsonData(IEnumerable items, bool onlyCount)
	{
		return GetInitialJsonData(items, onlyCount, null);
	}

	public static string GetInitialJsonData(IEnumerable items, bool onlyCount, ViewItemTransformation viewItemTransformation)
	{
		return GetInitialJsonData(items, onlyCount, viewItemTransformation, null);
	}

	public static string GetInitialJsonData(IEnumerable items, bool onlyCount, ViewItemTransformation viewItemTransformation, ITablePartMetadata metadata, bool recursive = true)
	{
		if (onlyCount)
		{
			return new TablePartChangesModel
			{
				TotalCount = items.OfType<IEntity>().Count()
			}.ToJson();
		}
		RevertNewItemsIds(items, metadata, recursive);
		return new TablePartChangesModel(items, items, viewItemTransformation).ToJson();
	}

	public static long GetLastTemporaryId()
	{
		return TablePartHelper.GetLastTemporaryId();
	}

	public static void SetLastTemporaryId(long id)
	{
		TablePartHelper.SetLastTemporaryId(id);
	}

	public static long GetNextTemporaryId()
	{
		return TablePartHelper.GetNextTemporaryId();
	}

	public static string GenerateGridId(string propertyName, Guid metadataUid, object parentId)
	{
		string text = ((parentId != null) ? parentId.ToString() : "");
		text = text.Replace("-", "m");
		if (text.IsNullOrWhiteSpace())
		{
			return string.Format("{0}_{1}", propertyName, metadataUid.ToString("n"));
		}
		return string.Format("{0}_{1}_{2}", propertyName, metadataUid.ToString("n"), text);
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, TablePartRequestData data)
	{
		CacheUpdate();
		data.command = command;
		Type type = GetType(data.uid);
		TablePartData data2 = DeserializeItems(data, type, !((ControllerBase)this).get_ControllerContext().get_IsChildAction());
		return GetGridResult(data2, isAnyChange: false, GetTablepartPrefix(data.uid));
	}

	[CustomGridAction]
	[TransactionAction(CommitOnResultExecuted = true)]
	public ActionResult Grid_Insert(GridCommand command, TablePartRequestData data)
	{
		CacheUpdate();
		data.command = command;
		Type type = GetType(data.uid);
		TablePartData tablePartData = DeserializeItems(data, type, bindParentProperties: true);
		tablePartData.ProcessDynamicForm = true;
		List<IEntity> obj = (List<IEntity>)tablePartData.Items;
		string tablepartPrefix = GetTablepartPrefix(data.uid);
		long nextTemporaryId = GetNextTemporaryId();
		Type entityIdType = ModelHelper.GetEntityIdType(type);
		IEntity entity = ((ModelHelper.GetEntityManagerOrNull(type) != null) ? LoadOrCreate(ModelHelper.GetEntityManager(type), type.ConvertId(entityIdType, nextTemporaryId)) : ((IEntity)InterfaceActivator.Create(type)));
		UpdateItem(entity, tablepartPrefix);
		ITablePartMetadata metadata = (ITablePartMetadata)MetadataLoader.LoadMetadata(type);
		IEntity parentObject = GetParentObject(metadata, type, data.parentDataObjectId, data.parentDataMetadataUid, data.parentRootJsonData);
		ElmaModelBinder.SetTablePartParent(entity, parentObject);
		obj.Add(entity);
		if (tablePartData.TablePartValues != null)
		{
			tablePartData.TablePartValues.Add((object)entity);
		}
		return GetGridResult(tablePartData, isAnyChange: true, tablepartPrefix);
	}

	[CustomGridAction]
	[TransactionAction(CommitOnResultExecuted = true)]
	public ActionResult Grid_Update(GridCommand command, [Bind(Prefix = "dataItem.Id")] string id, TablePartRequestData data)
	{
		CacheUpdate();
		data.command = command;
		Type type = GetType(data.uid);
		TablePartData tablePartData = DeserializeItems(data, type, bindParentProperties: true);
		tablePartData.ProcessDynamicForm = true;
		List<IEntity> source = (List<IEntity>)tablePartData.Items;
		string tablepartPrefix = GetTablepartPrefix(data.uid);
		Type entityIdType = ModelHelper.GetEntityIdType(type);
		object idValue = type.ConvertId(entityIdType, id);
		IEntity entity = source.FirstOrDefault((IEntity i) => i.GetId().Equals(idValue));
		if (entity != null)
		{
			UpdateItem(entity, tablepartPrefix);
		}
		return GetGridResult(tablePartData, isAnyChange: true, tablepartPrefix);
	}

	[CustomGridAction]
	[TransactionAction(CommitOnResultExecuted = true)]
	public ActionResult Grid_Delete(GridCommand command, [Bind(Prefix = "dataItem.Id")] string id, TablePartRequestData data)
	{
		CacheUpdate();
		data.command = command;
		Type type = GetType(data.uid);
		TablePartData tablePartData = DeserializeItems(data, type, bindParentProperties: true);
		tablePartData.ProcessDynamicForm = true;
		List<IEntity> list = (List<IEntity>)tablePartData.Items;
		Type entityIdType = ModelHelper.GetEntityIdType(type);
		object idValue = type.ConvertId(entityIdType, id);
		IEntity entity = list.FirstOrDefault((IEntity i) => i.GetId().Equals(idValue));
		if (entity != null)
		{
			list.Remove(entity);
			if (tablePartData.TablePartValues != null)
			{
				IEntity entity2 = ((IEnumerable)tablePartData.TablePartValues).OfType<IEntity>().FirstOrDefault((IEntity tpItem) => tpItem.GetId().Equals(idValue));
				if (entity2 != null)
				{
					tablePartData.TablePartValues.Remove((object)entity2);
				}
			}
		}
		tablePartData.DeletedItemsIds.Add(idValue);
		return GetGridResult(tablePartData, isAnyChange: true, GetTablepartPrefix(data.uid));
	}

	public ActionResult CreateForm(Guid uid)
	{
		CacheUpdate();
		GetType(uid);
		return (ActionResult)(object)((Controller)this).PartialView();
	}

	private string GetTablepartPrefix(Guid uid)
	{
		return $"Tablepart{uid:N}";
	}

	private IEntity LoadOrCreate(IEntityManager manager, object id)
	{
		return (IEntity)manager.LoadOrCreate(id);
	}

	private GridCommand GetGridCommand(TablePartData data, ClassMetadata metadata, GridCommand command)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		GridState gridState = GridPersonalizationAdministration.LoadState(data.Data.gridStateId, Guid.Empty);
		if (gridState != null)
		{
			if (command == null)
			{
				GridCommand val = new GridCommand();
				val.set_Page(gridState.CurrentPage);
				val.set_PageSize(gridState.PageSize);
				command = val;
			}
			if (gridState.GroupDescriptors != null)
			{
				command.get_GroupDescriptors().Clear();
				foreach (GridGroupDescriptor groupDescriptor in gridState.GroupDescriptors)
				{
					IList<GroupDescriptor> groupDescriptors = command.get_GroupDescriptors();
					GroupDescriptor val2 = new GroupDescriptor();
					((SortDescriptor)val2).set_Member(groupDescriptor.Member);
					((SortDescriptor)val2).set_SortDirection(groupDescriptor.SortDirection);
					groupDescriptors.Add(val2);
				}
			}
		}
		else
		{
			if (command == null)
			{
				int pageSize = ((data.TableView != null && data.TableView.PageSize > 1) ? data.TableView.PageSize : 15);
				GridCommand val3 = new GridCommand();
				val3.set_PageSize(pageSize);
				val3.set_Page(1);
				command = val3;
			}
			if (metadata != null && data.TableView != null && data.TableView.GroupDescriptors != null)
			{
				command.get_GroupDescriptors().Clear();
				foreach (TableViewGroupDescriptor groupDescriptor2 in data.TableView.GroupDescriptors)
				{
					Guid propertyUid2 = groupDescriptor2.PropertyUid;
					PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Uid == propertyUid2);
					if (propertyMetadata != null)
					{
						IList<GroupDescriptor> groupDescriptors2 = command.get_GroupDescriptors();
						GroupDescriptor val4 = new GroupDescriptor();
						((SortDescriptor)val4).set_Member(propertyMetadata.Name);
						((SortDescriptor)val4).set_SortDirection(groupDescriptor2.Direction);
						groupDescriptors2.Add(val4);
					}
				}
			}
		}
		if (gridState != null && !gridState.SortExpression.IsNullOrWhiteSpace())
		{
			command.get_SortDescriptors().Clear();
			IList<SortDescriptor> sortDescriptors = command.get_SortDescriptors();
			SortDescriptor val5 = new SortDescriptor();
			val5.set_Member(gridState.SortExpression);
			val5.set_SortDirection(gridState.SortDirection);
			sortDescriptors.Add(val5);
		}
		else if (metadata != null && data.TableView != null && data.TableView.SortDescriptors != null)
		{
			command.get_SortDescriptors().Clear();
			{
				foreach (TableViewSortDescriptor sortDescriptor in data.TableView.SortDescriptors)
				{
					Guid propertyUid = sortDescriptor.PropertyUid;
					PropertyMetadata propertyMetadata2 = metadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Uid == propertyUid);
					if (propertyMetadata2 != null)
					{
						IList<SortDescriptor> sortDescriptors2 = command.get_SortDescriptors();
						SortDescriptor val6 = new SortDescriptor();
						val6.set_Member(propertyMetadata2.Name);
						val6.set_SortDirection(sortDescriptor.Direction);
						sortDescriptors2.Add(val6);
					}
				}
				return command;
			}
		}
		return command;
	}

	private void CacheUpdate()
	{
		if (!((ControllerBase)this).get_ControllerContext().get_IsChildAction())
		{
			((Controller)this).get_Response().Cache.SetNoServerCaching();
			((Controller)this).get_Response().Cache.SetNoStore();
			((Controller)this).get_Response().Cache.SetLastModified(DateTime.Now);
		}
	}

	private Type GetType(Guid uid)
	{
		Type typeByUid = IMetadataRuntimeService.GetTypeByUid(uid);
		if (typeByUid == null)
		{
			return null;
		}
		return typeByUid;
	}

	private TablePartData DeserializeItems(TablePartRequestData data, Type itemType, bool bindParentProperties = false)
	{
		ElmaModelBinder.ResetTablePartNewItemIds = false;
		ITablePartMetadata tablePartMetadata = (ITablePartMetadata)MetadataLoader.LoadMetadata(itemType);
		IEnumerable enumerable = null;
		IEntity parentObject = GetParentObject(tablePartMetadata, itemType, data.parentDataObjectId, data.parentDataMetadataUid, data.parentRootJsonData, bindParentProperties);
		if (parentObject != null)
		{
			enumerable = parentObject.GetPropertyValue(tablePartMetadata.TablePartPropertyUid) as IEnumerable;
		}
		ISet val = (ISet)(object)new HashedSet<IEntity>();
		if (enumerable != null)
		{
			foreach (IEntity item in enumerable.OfType<IEntity>())
			{
				val.Add((object)item);
			}
			enumerable = (from e in enumerable.OfType<IEntity>()
				where !e.IsNew()
				select e).ToList();
		}
		TablePartChangesModel tablePartChangesModel = null;
		ViewItemTransformation viewItemTransformation = null;
		if (!string.IsNullOrEmpty(data.jsonData))
		{
			tablePartChangesModel = new JsonSerializer().Deserialize<TablePartChangesModel>(data.jsonData);
			if (tablePartChangesModel != null)
			{
				tablePartChangesModel.Apply(val, itemType);
				viewItemTransformation = tablePartChangesModel.ViewItemTransformation;
				foreach (IEntity item2 in (IEnumerable)val)
				{
					ElmaModelBinder.SetTablePartParent(item2, parentObject);
				}
			}
		}
		TablePartData tablePartData = new TablePartData(data, enumerable, ((IEnumerable)val).OfType<IEntity>().ToList())
		{
			Parent = parentObject,
			OriginalChangesModel = tablePartChangesModel,
			JsonData = tablePartChangesModel?.ToDictionary(),
			ViewItemTransformation = viewItemTransformation
		};
		if (parentObject != null)
		{
			object propertyValue = parentObject.GetPropertyValue(tablePartMetadata.TablePartPropertyUid);
			tablePartData.TablePartValues = (ISet)((propertyValue is ISet) ? propertyValue : null);
			List<IEntity> list = new List<IEntity>();
			list.Add(parentObject.GetRootEntity());
			list.AddRange(parentObject.GetRootEntity().GetContainedEntities());
			IUnitOfWorkManager serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
			{
				foreach (IEntity item3 in list)
				{
					serviceNotNull.RevertEntityChangesOnCommit("", item3);
				}
				return tablePartData;
			}
		}
		return tablePartData;
	}

	private void UpdateItem(IEntity item, string prefix)
	{
		object id = item.GetId();
		((Controller)this).TryUpdateModel<IEntity>(item, $"dataItem.{prefix}", (string[])null, new string[2] { "Uid", "__settings" });
		item.SetId(id);
	}

	private bool IsRequiredProperty(PropertyInfo propInfo)
	{
		if (!propInfo.Metadata.Required)
		{
			return propInfo.ViewItem.Attributes.Required;
		}
		return true;
	}

	private int FindEmptyEntityValue(PropertyInfo propInfo, IEnumerable<IEntity> entityValues)
	{
		return entityValues.Select((IEntity entity, int index) => new
		{
			Value = entity.GetPropertyValue(propInfo.PropertyUid),
			Index = index
		}).FirstOrDefault(item =>
		{
			if (propInfo.IsTablePart)
			{
				if (item.Value is ISet)
				{
					object value = item.Value;
					return ((ISet)((value is ISet) ? value : null)).get_IsEmpty();
				}
				return false;
			}
			return IMetadataRuntimeService.GetTypeDescriptor(propInfo.Metadata.TypeUid, propInfo.Metadata.SubTypeUid).IsEmpty((PropertyMetadata)propInfo.Metadata, item.Value);
		})?.Index ?? (-1);
	}

	private ActionResult GetGridResult(TablePartData data, bool isAnyChange, string prefix)
	{
		GridStateSaveMode value = (from x in ComponentManager.Current.GetExtensionPoints<ITablePartGridStateSaveModeProvider>()
			select x.GetGridStateSaveMode(data.Data.uid)).First((GridStateSaveMode? x) => x.HasValue).Value;
		return GetGridResult(data, isAnyChange, prefix, value);
	}

	private bool IsSubTablePart(ITablePartMetadata metadata)
	{
		PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Uid == metadata.ParentPropertyUid);
		if (propertyMetadata != null)
		{
			return MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid) is ITablePartMetadata;
		}
		return false;
	}

	private ActionResult GetGridResult(TablePartData data, bool isAnyChange, string prefix, GridStateSaveMode gridStateSaveMode)
	{
		((Controller)this).get_RouteData().Values.Remove("jsonData");
		if (isAnyChange)
		{
			((Controller)this).get_RouteData().Values.Remove("gridId");
		}
		else
		{
			((Controller)this).get_RouteData().Values["gridId"] = data.Data.gridId;
		}
		if (!string.IsNullOrEmpty(data.Data.viewProviderUid))
		{
			((Controller)this).get_RouteData().Values["viewProviderUid"] = data.Data.viewProviderUid;
			((Controller)this).get_RouteData().Values["viewItemId"] = data.Data.viewItemId;
			((ControllerBase)this).get_ViewData().set_Item("viewProviderUid", (object)new Guid(data.Data.viewProviderUid));
			((ControllerBase)this).get_ViewData().set_Item("viewItemId", (object)data.Data.viewItemId);
		}
		if (!string.IsNullOrEmpty(data.Data.dynamicFormsProviderUid))
		{
			((Controller)this).get_RouteData().Values["dynamicFormsProviderUid"] = data.Data.dynamicFormsProviderUid;
			((Controller)this).get_RouteData().Values["dynamicFormsProviderData"] = data.Data.dynamicFormsProviderData;
			((ControllerBase)this).get_ViewData().set_Item("dynamicFormsProviderUid", (object)new Guid(data.Data.dynamicFormsProviderUid));
			((ControllerBase)this).get_ViewData().set_Item("dynamicFormsProviderData", (object)data.Data.dynamicFormsProviderData);
		}
		if (!string.IsNullOrEmpty(data.Data.parentFormId))
		{
			((Controller)this).get_RouteData().Values["parentFormId"] = data.Data.parentFormId;
			((ControllerBase)this).get_ViewData().set_Item("parentFormId", (object)data.Data.parentFormId);
		}
		Type type = IMetadataRuntimeService.GetTypeByUid(data.Data.uid);
		ITablePartMetadata metadata = (ITablePartMetadata)MetadataLoader.LoadMetadata(type, inherit: false);
		data.TableView = ((metadata != null && ((ClassMetadata)metadata).TableViews != null) ? ((ClassMetadata)metadata).TableViews.FirstOrDefault((TableView v) => v.ViewType == ViewType.List) : null);
		TableView tableView = data.TableView;
		RootViewItem rootViewItem = null;
		if (!string.IsNullOrEmpty(data.Data.viewProviderUid))
		{
			Guid providerUid = new Guid(data.Data.viewProviderUid);
			IObjectViewItemProvider objectViewItemProvider = ComponentManager.Current.GetExtensionPoints<IObjectViewItemProvider>().FirstOrDefault((IObjectViewItemProvider p) => p.ProviderUid == providerUid);
			if (objectViewItemProvider != null)
			{
				rootViewItem = objectViewItemProvider.GetViewItem(data.Data.viewItemId) as RootViewItem;
			}
		}
		if (rootViewItem is FormViewItem)
		{
			ComponentManager.Current.GetExtensionPoints<IFormViewItemTransformate>().Each(delegate(IFormViewItemTransformate p)
			{
				rootViewItem = p.Transformate(rootViewItem as FormViewItem, null);
			});
		}
		PropertyViewItem viewItem = null;
		if (rootViewItem != null)
		{
			if (data.Data.viewItemUid.HasValue)
			{
				viewItem = rootViewItem.FindItem(data.Data.viewItemUid.Value) as PropertyViewItem;
			}
			if (viewItem == null)
			{
				viewItem = rootViewItem.FindItem((PropertyViewItem i) => i.PropertyUid == metadata.TablePartPropertyUid);
			}
			if (viewItem != null && data.ViewItemTransformation != null)
			{
				viewItem = (PropertyViewItem)viewItem.Clone();
				data.ViewItemTransformation.Apply(viewItem);
			}
		}
		data.EditingItemView = viewItem;
		InitDynamicForm(data, metadata, rootViewItem, viewItem);
		data.InitJsonData();
		if (!string.IsNullOrWhiteSpace(data.Data.jsonDataHiddenFieldId))
		{
			((ControllerBase)this).get_ViewData().set_Item("jsonDataHiddenFieldId", (object)data.Data.jsonDataHiddenFieldId);
		}
		if (!string.IsNullOrEmpty(data.Data.parentDataHiddenFieldId))
		{
			((ControllerBase)this).get_ViewData().set_Item("parentDataHiddenFieldId", (object)data.Data.parentDataHiddenFieldId);
		}
		if (data.Data.command == null || (string.IsNullOrEmpty(data.Data.command.get_SortExpressionString()) && !data.TableView.Sortable))
		{
			data.Data.command = GetGridCommand(data, (ClassMetadata)metadata, data.Data.command);
		}
		List<IEntity> first = data.Items.OfType<IEntity>().ToList();
		IGridData gridData = GetGridData(data);
		ITablePartContainer tablePartContainer = metadata as ITablePartContainer;
		int num = -1;
		if (viewItem != null)
		{
			List<IEntity> list = new List<IEntity>();
			foreach (object item3 in data.Items)
			{
				AggregateFunctionsGroup val = (AggregateFunctionsGroup)((item3 is AggregateFunctionsGroup) ? item3 : null);
				if (val != null)
				{
					list = list.Concat(((Group)val).get_Items().OfType<IEntity>()).ToList();
				}
				if (item3 is IEntity item)
				{
					list.Add(item);
				}
			}
			first = first.Except(list).ToList();
			IEnumerable<IPropertyMetadata> first2;
			if (tablePartContainer == null)
			{
				IEnumerable<IPropertyMetadata> enumerable = new List<IPropertyMetadata>();
				first2 = enumerable;
			}
			else
			{
				first2 = tablePartContainer.TableParts.Cast<IPropertyMetadata>();
			}
			IEnumerable<IPropertyMetadata> second = metadata.Properties.Where((PropertyMetadata p) => !p.IsSystem).Cast<IPropertyMetadata>();
			foreach (PropertyInfo item4 in from meta in first2.Concat(second)
				select new PropertyInfo
				{
					PropertyUid = meta.PropertyUid,
					IsTablePart = (meta is ITablePartMetadata),
					Metadata = meta,
					ViewItem = viewItem.FindItem((PropertyViewItem i) => !i.Hide && i.PropertyUid == meta.PropertyUid)
				} into p
				where p.ViewItem != null && IsRequiredProperty(p)
				select p)
			{
				num = FindEmptyEntityValue(item4, first);
				if (num >= 0)
				{
					break;
				}
			}
		}
		DynamicGrid grid = new DynamicGrid(data.Data.gridId, data.Data.gridId, gridData, type, null, data.Data.gridStateId);
		grid.ExportExcel = true;
		grid.EmptyDataPage = ((num >= 0) ? 1 : 0);
		GridState gridState = null;
		bool flag = false;
		if (IsSubTablePart(metadata))
		{
			gridState = grid.CreateDefaultState(GridStateSaveMode.None);
			flag = true;
		}
		else
		{
			gridState = GridPersonalizationAdministration.LoadState(data.Data.gridStateId, Guid.Empty);
			if (gridState != null)
			{
				gridState.Refresh(grid.Type, isNew: false, forceRefresh: false, addEntityName: false);
			}
			else
			{
				gridState = grid.CreateDefaultState(gridStateSaveMode);
				flag = true;
			}
		}
		gridState.ReloadFromMetadata(type);
		grid.Columns = GridBuilderExtensions.GetDefaultColumns(type, (ClassMetadata)metadata, gridState, childs: false, null, (viewItem != null) ? (from i in viewItem.GetAllProperties()
			select i.PropertyUid) : null);
		if (viewItem != null && gridState != null)
		{
			Dictionary<Guid, KeyValuePair<PropertyMetadata, ClassMetadata>> metadataProperties = null;
			IOrderedEnumerable<ColumnState> source = gridState.ColumnStates.OrderBy((ColumnState a) => a.Order);
			bool flag2 = false;
			ColumnState[] array = source.ToArray();
			foreach (ColumnState c2 in array)
			{
				Guid.TryParse(c2.UniqueName, out var columnUid2);
				PropertyViewItem propertyViewItem = ((columnUid2 != Guid.Empty) ? viewItem.GetAllProperties().FirstOrDefault((PropertyViewItem i) => i.PropertyUid == columnUid2) : null);
				c2.Hidden = propertyViewItem == null;
				GridColumn gridColumn = grid.Columns.OrderBy((GridColumn a) => a.Order).FirstOrDefault((GridColumn c1) => c1.UniqueName == c2.UniqueName);
				if (gridColumn == null)
				{
					continue;
				}
				gridColumn.Visible = !c2.Hidden;
				gridColumn.ReadOnly = propertyViewItem?.IsReadOnly() ?? false;
				if (!gridColumn.Visible || propertyViewItem == null)
				{
					continue;
				}
				if (tableView != null && tableView.Reorderable)
				{
					if (!flag)
					{
						gridColumn.Order = c2.Order;
					}
					else
					{
						c2.Order = gridColumn.Order;
						flag2 = true;
					}
				}
				if (propertyViewItem.EditableInTable)
				{
					gridColumn.EditableInTable = true;
					gridColumn.Groupable = false;
				}
				if (!string.IsNullOrWhiteSpace(propertyViewItem.Attributes.LocalizableName))
				{
					gridColumn.Header = propertyViewItem.Attributes.LocalizableName;
				}
			}
			GridColumn[] array2 = grid.Columns.OrderBy((GridColumn a) => a.Order).ToArray();
			GridColumn[] array3 = array2;
			foreach (GridColumn gridColumn2 in array3)
			{
				Guid.TryParse(gridColumn2.UniqueName, out var columnUid);
				PropertyViewItem propertyView = ((columnUid != Guid.Empty) ? viewItem.GetAllProperties().FirstOrDefault((PropertyViewItem i) => i.PropertyUid == columnUid) : null);
				if (!gridColumn2.Visible || propertyView == null)
				{
					continue;
				}
				flag2 |= AddSubProperties(propertyView, grid, gridColumn2, new Lazy<KeyValuePair<PropertyMetadata, ClassMetadata>>(() => (metadataProperties ?? (metadataProperties = MetadataLoader.GetBasePropertiesAndMetadata((ClassMetadata)metadata).Concat(metadata.Properties.Select((PropertyMetadata p) => new KeyValuePair<PropertyMetadata, ClassMetadata>(p, (ClassMetadata)metadata))).ToDictionary((KeyValuePair<PropertyMetadata, ClassMetadata> i) => i.Key.Uid)))[propertyView.PropertyUid]), data.Data.uid, gridState, array2);
			}
			if (flag2)
			{
				gridState.SaveOnlyInSession = gridStateSaveMode == GridStateSaveMode.SaveInSession;
				if (gridStateSaveMode != 0)
				{
					GridPersonalizationAdministration.SaveState(data.Data.gridStateId, gridState, Guid.Empty, true);
				}
				if (gridStateSaveMode == GridStateSaveMode.SaveInSessionAndDb)
				{
					GridPersonalizationAdministration.SaveState(data.Data.gridStateId, gridState, Guid.Empty, false);
				}
			}
		}
		grid.Customizable = tableView?.Customizable ?? true;
		grid.HeaderVisible = tableView?.ShowHeader ?? true;
		grid.Resizeable = tableView?.Resizeable ?? true;
		grid.LockedResizeMode = ColumnResizeMode.Web;
		grid.Reorderable = tableView?.Reorderable ?? true;
		grid.Sortable = tableView?.Sortable ?? true;
		grid.Groupable = tableView?.Groupable ?? true;
		grid.GroupableExpand = tableView?.GroupableExpand ?? true;
		grid.Customizable = false;
		grid.ShowEditorsDescription = data.Data.showEditorsDescription;
		grid.EditBrowserHistory = false;
		bool flag3 = (viewItem == null || !viewItem.IsReadOnly()) && !data.Data.readOnly && !data.Data.fullReadOnly;
		bool flag4 = grid.Columns.Any((GridColumn c) => c.Visible && !c.ReadOnly) || HasNonReadOnlyColumns(viewItem, metadata);
		grid.CanInsert = flag3 && flag4 && (tableView?.CanAdd ?? true);
		grid.AddRowMode = tableView?.AddRowMode ?? TableRowEditMode.PopUp;
		grid.CanEdit = !data.Data.fullReadOnly && (flag4 || flag3) && (tableView?.CanEdit ?? true);
		grid.EditRowMode = tableView?.EditRowMode ?? TableRowEditMode.PopUpAndTable;
		grid.CanDelete = flag3 && (tableView?.CanDelete ?? true);
		bool flag5 = tablePartContainer != null && tablePartContainer.TableParts.Count > 0 && (viewItem == null || tablePartContainer.TableParts.Any((ITablePartMetadata tp) => (from i in viewItem.GetAllProperties()
			where i.PropertyUid == tp.TablePartPropertyUid
			select i) != null));
		if (grid.AddRowMode == TableRowEditMode.Table && flag5)
		{
			grid.AddRowMode = TableRowEditMode.PopUp;
		}
		if ((grid.EditRowMode == TableRowEditMode.Table || grid.EditRowMode == TableRowEditMode.PopUpAndTable) && flag5)
		{
			grid.EditRowMode = TableRowEditMode.PopUp;
		}
		if (data.DynamicFormSettings != null)
		{
			grid.FormContentAccessor = (HtmlHelper html) => ((HtmlString)(object)html.DynamicFormSettings(data.DynamicFormSettings, string.Empty)).ToHtmlString() + $"\r\n<input name=\"{prefix}.TypeUid\" type=\"hidden\" value=\"{metadata.Uid}\" />";
		}
		IEntity entity = (IEntity)InterfaceActivator.Create(type);
		SetParent(entity, metadata, data.Parent);
		grid.DefaultDataItem = entity;
		try
		{
			if (!string.IsNullOrEmpty(gridState.SortExpression))
			{
				string dbSortExpression = gridState.GetDbSortExpression(grid.Childs);
				if (!dbSortExpression.Equals(gridState.SortExpression))
				{
					gridState.SortExpression = dbSortExpression;
				}
				grid.GridData.SortExpression = dbSortExpression;
				grid.GridData.SortDirection = gridState.SortDirection;
			}
			else
			{
				grid.GridData.SortExpression = null;
			}
			grid.GridData.PageSize = gridState.PageSize;
			grid.GridData.GroupDescriptors = gridState.GroupDescriptors;
		}
		catch (Exception exception)
		{
			base.Logger.Error("Cannot apply state", exception);
		}
		grid.ItemEditorTemplateName = "TablePartItem";
		if (grid.Resizeable)
		{
			foreach (GridColumn column in grid.Columns)
			{
				if (string.IsNullOrEmpty(column.Width))
				{
					column.Width = "160px";
				}
			}
		}
		TablePartGridModel tablePartGridModel = new TablePartGridModel
		{
			Grid = grid,
			Metadata = metadata,
			EditingItemView = data.EditingItemView
		};
		if (!string.IsNullOrEmpty(data.Data.editingItem_id))
		{
			Type idType = ModelHelper.GetEntityIdType(type);
			IEntity entity2;
			ViewType viewType;
			if (type.IsDefaultId(idType, data.Data.editingItem_id))
			{
				long nextTemporaryId = GetNextTemporaryId();
				IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(type);
				entity2 = ((entityManagerOrNull != null) ? LoadOrCreate(entityManagerOrNull, type.ConvertId(idType, nextTemporaryId)) : ((IEntity)InterfaceActivator.Create(type)));
				SetParent(entity2, metadata, data.Parent);
				viewType = ViewType.Create;
			}
			else
			{
				List<IEntity> list2 = new List<IEntity>();
				Stack<object> stack = new Stack<object>(data.Items.Cast<object>().Reverse());
				while (stack.Count > 0)
				{
					object obj = stack.Pop();
					AggregateFunctionsGroup val2 = (AggregateFunctionsGroup)((obj is AggregateFunctionsGroup) ? obj : null);
					if (val2 != null)
					{
						((Group)val2).get_Items().Cast<object>().Reverse()
							.ForEach(delegate(object o)
							{
								stack.Push(o);
							});
					}
					else if (obj is IEntity item2)
					{
						list2.Add(item2);
					}
				}
				entity2 = list2.FirstOrDefault((IEntity e) => e.GetId().Equals(type.ConvertId(idType, data.Data.editingItem_id)));
				viewType = ViewType.Edit;
			}
			if (data.Data.editInPopUp)
			{
				grid.GridData.EditingItem = entity2;
			}
			if (data.DynamicFormSettings != null)
			{
				ExecuteOnViewLoadScript(entity2, data, metadata, viewItem, viewType);
				grid.GridData.EditingItemView = data.EditingItemView;
				tablePartGridModel.EditingItemView = data.EditingItemView;
			}
			if (type.IsDefaultId(idType, data.Data.editingItem_id))
			{
				grid.DefaultDataItem = entity2;
				grid.RenderDefaultDataItemEditors = true;
			}
		}
		((ControllerBase)this).get_ViewData().set_Item("View", (object)tablePartGridModel.EditingItemView);
		((ControllerBase)this).get_ViewData().set_Item("DynamicFormSettings", (object)data.DynamicFormSettings);
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		grid.ClientEvents = delegate(GridClientEventsBuilder ce)
		{
			ce.OnLoad((Func<object, object>)((object writer) => string.Format("function(evt){{var grid=$(this).data('tGrid');grid.jsonDataHiddenFieldId='{0}';grid.setJsonData('{1}');grid.parentDataHiddenFieldId='{2}';grid.parentDataObjectId='{3}';grid.parentDataMetadataUid='{4}';if (!$.telerik.grid.lastTemporaryId || parseInt($.telerik.grid.lastTemporaryId) > {5}) {{ $.telerik.grid.lastTemporaryId={5}; }}jQuery.each(grid.$rows(), function(i, row){{grid.expandRow(row);}});if ($(this).parents('.portlet').length) {{ $(this).find('.t-grouping-row').each(function() {{ grid.collapseGroup(this); }}); }}}}", gridData.JsonDataHiddenFieldId, ((HtmlString)(object)gridData.JsonData.ToJson()).ToHtmlString().Replace("\\", "\\\\").Replace("\n", "\\n")
				.Replace("\r", "\\r")
				.Replace("'", "\\'"), gridData.ParentDataHiddenFieldId, gridData.ParentDataObjectId, gridData.ParentDataMetadataUid, GetLastTemporaryId())));
			if (!grid.GroupableExpand)
			{
				ce.OnDataBound((Func<object, object>)((object _) => "function(evt) { if ($(this).parents('.portlet').length) { var grid=$(this).data('tGrid'); $(this).find('.t-grouping-row').each(function() { grid.collapseGroup(this); }); }}"));
			}
			ce.OnRowDataBound((Func<object, object>)((object writer) => "function(evt){var grid=$(this).data('tGrid');grid.expandRow(evt.row);}"));
		};
		if (IsExportExcel())
		{
			GridExportExcelOptions gridExportExcelOptions = new GridExportExcelOptions
			{
				GridState = gridState
			};
			if (grid.Columns.Any((GridColumn x) => x.Order != int.MinValue))
			{
				gridExportExcelOptions.ColumnOrderOverride = grid.Columns.ToDictionary((GridColumn key) => key.UniqueName, (GridColumn column) => column.Order);
			}
			else
			{
				gridExportExcelOptions.ColumnOrderOverride = grid.Columns.ToDictionary((GridColumn key) => key.UniqueName, (GridColumn column) => grid.Columns.IndexOf(column));
			}
			return ExportExcel(gridData, type, delegate
			{
				throw new InvalidOperationException(SR.T("Ошибка экспорта в файл Excel"));
			}, gridExportExcelOptions);
		}
		PartialViewResult val3 = ((Controller)this).PartialView("TablePart/Grid", (object)tablePartGridModel);
		if (data.DynamicFormResult == null)
		{
			return (ActionResult)(object)val3;
		}
		return (ActionResult)(object)new CompositeActionResult((IEnumerable<ActionResult>)(object)new ActionResult[2]
		{
			(ActionResult)new JsonCatchViewResult((ViewResultBase)(object)val3, (ControllerContext context) => (IDictionary<string, object>)context.get_HttpContext().Items["GridResultDictionary"]),
			data.DynamicFormResult
		}, delegate(ControllerContext context, IEnumerable<ActionResult> results)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			foreach (JsonCatchViewResult item5 in results.OfType<JsonCatchViewResult>())
			{
				if (item5.JsonResult != null)
				{
					foreach (KeyValuePair<string, object> item6 in item5.JsonResult)
					{
						dictionary.Add(item6.Key, item6.Value);
					}
				}
			}
			MvcHtmlString value = dictionary.ToJson();
			context.get_HttpContext().Response.Output.Write(value);
		})
		{
			ResultType = ActionResultType.Json
		};
	}

	private bool AddSubProperties(PropertyViewItem propertyView, DynamicGrid grid, GridColumn parentColumn, Lazy<KeyValuePair<PropertyMetadata, ClassMetadata>> propMetadata, Guid typeUid, GridState gridState, IEnumerable<GridColumn> baseColumns, ref int addedColumnCount)
	{
		bool flag = false;
		bool flag2 = addedColumnCount == 0;
		PropertyViewItem[] array = propertyView.GetAllProperties().ToArray();
		if (array.Length != 0)
		{
			ClassMetadata propClassMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(propMetadata.Value.Key.SubTypeUid, inherit: false);
			Dictionary<Guid, KeyValuePair<PropertyMetadata, ClassMetadata>> dictionary = MetadataLoader.GetBasePropertiesAndMetadata(propClassMetadata).Concat(propClassMetadata.Properties.Select((PropertyMetadata p) => new KeyValuePair<PropertyMetadata, ClassMetadata>(p, propClassMetadata))).ToDictionary((KeyValuePair<PropertyMetadata, ClassMetadata> i) => i.Key.Uid);
			int num = parentColumn.Order;
			string uniqueName = parentColumn.UniqueName;
			PropertyViewItem[] array2 = array;
			foreach (PropertyViewItem propertyViewItem in array2)
			{
				if (!dictionary.TryGetValue(propertyViewItem.PropertyUid, out var pair))
				{
					continue;
				}
				PropertyMetadata key = pair.Key;
				EntitySettings entitySettings = key.Settings as EntitySettings;
				Type propertyType = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(pair.Value.Uid).GetReflectionProperty(key.Name).PropertyType;
				string uniqueName2 = (uniqueName + "_" + key.UidStr).GetDeterministicGuid().ToString();
				ColumnState columnState = gridState.ColumnStates[uniqueName2];
				addedColumnCount++;
				num++;
				DynamicGridColumn column = new DynamicGridColumn
				{
					Header = ((!string.IsNullOrWhiteSpace(propertyViewItem.Attributes.LocalizableName)) ? propertyViewItem.Attributes.LocalizableName : key.DisplayName),
					SortExpression = parentColumn.Name + "." + key.Name,
					Sortable = (key.Sortable && (entitySettings == null || entitySettings.RelationType == RelationType.OneToOne)),
					Groupable = key.Groupable,
					CellAlignment = key.TableCellAlignment,
					UniqueName = uniqueName2,
					Name = parentColumn.Name + "." + key.Name,
					ReadOnly = propertyViewItem.IsReadOnly(),
					Metadata = pair.Value,
					ValueType = propertyType,
					Width = ((columnState != null && !string.IsNullOrEmpty(columnState.WidthAttribute)) ? (columnState.WidthAttribute + "px") : ((key.TableColumnWidth > 0) ? (key.TableColumnWidth + "px") : "")),
					Order = (columnState?.Order ?? num)
				};
				grid.Columns.Add(column);
				if (columnState == null)
				{
					columnState = new ColumnState
					{
						UniqueName = column.UniqueName,
						TypeUid = typeUid,
						Hidden = column.Hidden,
						Order = column.Order,
						Sortable = column.Sortable
					};
					gridState.ColumnStates.Add(columnState);
					if (!gridState.CustomColumns.Any((CustomColumnDescriptor col) => col.UniqueName == column.UniqueName))
					{
						CustomColumnDescriptor item = new CustomColumnDescriptor
						{
							DisplayName = (column.Header as string),
							Sortable = column.Sortable,
							SortExpression = column.SortExpression,
							UniqueName = column.UniqueName,
							Visible = !column.Hidden
						};
						gridState.CustomColumns.Add(item);
					}
					flag = true;
				}
				int num2 = addedColumnCount;
				flag |= AddSubProperties(propertyViewItem, grid, column, new Lazy<KeyValuePair<PropertyMetadata, ClassMetadata>>(() => pair), typeUid, gridState, null, ref addedColumnCount);
				if (addedColumnCount > num2)
				{
					num += addedColumnCount - num2;
				}
			}
			if (flag2 && addedColumnCount > 0 && baseColumns != null)
			{
				int num3 = parentColumn.Order + addedColumnCount;
				for (int k = baseColumns.IndexOf(parentColumn) + 1; k < baseColumns.Count(); k++)
				{
					GridColumn gridColumn = baseColumns.ElementAt(k);
					if (flag)
					{
						if (gridColumn.Order <= num3)
						{
							gridColumn.Order = num3 + 1;
							gridState.ColumnStates[gridColumn.UniqueName].Order = gridColumn.Order;
						}
					}
					else
					{
						gridColumn.Order = gridState.ColumnStates[gridColumn.UniqueName].Order;
					}
				}
			}
		}
		return flag;
	}

	private bool AddSubProperties(PropertyViewItem propertyView, DynamicGrid grid, GridColumn parentColumn, Lazy<KeyValuePair<PropertyMetadata, ClassMetadata>> propMetadata, Guid typeUid, GridState gridState, IEnumerable<GridColumn> baseColumns)
	{
		int addedColumnCount = 0;
		return AddSubProperties(propertyView, grid, parentColumn, propMetadata, typeUid, gridState, baseColumns, ref addedColumnCount);
	}

	private void ExecuteOnViewLoadScript(IEntity item, TablePartData data, ITablePartMetadata metadata, PropertyViewItem tablePartViewItem, ViewType viewType)
	{
		if (item == null || data == null || data.DynamicFormSettings == null || metadata == null)
		{
			return;
		}
		string text = ((tablePartViewItem != null && !string.IsNullOrEmpty(tablePartViewItem.Attributes.OnViewLoadScriptName)) ? tablePartViewItem.Attributes.OnViewLoadScriptName : metadata.OnViewLoadScriptName);
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		RootViewItem view = ((data.EditingItemView != null) ? ClassSerializationHelper.CloneObjectByXml(data.EditingItemView) : new FormView((ClassMetadata)metadata, viewType, ItemType.Default));
		DynamicFormPropertyChangedData dynamicFormPropertyChangedData = new DynamicFormPropertyChangedData();
		((Controller)this).TryUpdateModel<DynamicFormPropertyChangedData>(dynamicFormPropertyChangedData, string.Join(".", "dataItem", "ParentB5857BD3_6DBE_48F0_9489_FD6C08F1528E", "__DynamicFormSettings"));
		if (!(dynamicFormPropertyChangedData.ViewProviderUid == Guid.Empty))
		{
			dynamicFormPropertyChangedData.ChangedPropertyName = metadata.TablePartPropertyName;
			DynamicFormsController.DynamicFormChangeViewResultBase dynamicFormChangeViewResultBase = (DynamicFormsController.DynamicFormChangeViewResultBase)(object)DynamicFormsController.ProcessPropertyValueChanged((Controller)(object)this, dynamicFormPropertyChangedData, item, text, view);
			data.DynamicFormSettings.ModelJsonState = dynamicFormChangeViewResultBase.Result.ModelJsonState;
			if (!string.IsNullOrEmpty(dynamicFormChangeViewResultBase.Result.ViewTransformation))
			{
				data.DynamicFormSettings.ViewTransformation = ViewItemTransformation.DeserializeFromJson(dynamicFormChangeViewResultBase.Result.ViewTransformation);
			}
			if (((ViewResultBase)dynamicFormChangeViewResultBase).get_ViewData().get_Item("DynamicFormChangeResultViewModel") is DynamicFormChangeResultViewModel dynamicFormChangeResultViewModel)
			{
				data.EditingItemView = dynamicFormChangeResultViewModel.View;
			}
			data.DynamicFormResult = (ActionResult)(object)dynamicFormChangeViewResultBase;
		}
	}

	private void InitDynamicForm(TablePartData data, ITablePartMetadata metadata, RootViewItem rootViewItem, PropertyViewItem tpView)
	{
		DynamicFormSettings dynamicFormSettings = null;
		if (!string.IsNullOrEmpty(data.Data.dynamicFormsProviderUid))
		{
			string parentFormId = data.Data.parentFormId;
			dynamicFormSettings = new DynamicFormSettings
			{
				FormId = data.Data.gridId.ToString() + "form",
				ParentFormId = ((!string.IsNullOrEmpty(parentFormId)) ? parentFormId : "GlobalForm"),
				ParentPropertyFieldId = data.Data.jsonDataHiddenFieldId,
				DynamicFormsProviderUid = new Guid(data.Data.dynamicFormsProviderUid),
				DynamicFormsProviderData = data.Data.dynamicFormsProviderData,
				ViewProviderUid = ((!string.IsNullOrEmpty(data.Data.viewProviderUid)) ? new Guid(data.Data.viewProviderUid) : Guid.Empty),
				ViewItemId = data.Data.viewItemId,
				ViewItemUid = data.Data.viewItemUid
			};
		}
		data.DynamicFormSettings = dynamicFormSettings;
		if (!data.ProcessDynamicForm)
		{
			return;
		}
		string text = null;
		if (tpView != null && tpView.Attributes != null && !string.IsNullOrEmpty(tpView.Attributes.OnChangeScriptName))
		{
			text = tpView.Attributes.OnChangeScriptName;
		}
		if (text == null && !string.IsNullOrEmpty(metadata.OnChangeScriptName))
		{
			text = metadata.OnChangeScriptName;
		}
		if (text != null)
		{
			DynamicFormPropertyChangedData dynamicFormPropertyChangedData = new DynamicFormPropertyChangedData();
			((Controller)this).TryUpdateModel<DynamicFormPropertyChangedData>(dynamicFormPropertyChangedData, string.Join(".", "dataItem", "ParentB5857BD3_6DBE_48F0_9489_FD6C08F1528E", "__DynamicFormSettings"));
			dynamicFormPropertyChangedData.ChangedPropertyName = metadata.TablePartPropertyName;
			if (dynamicFormPropertyChangedData != null && data.Parent != null)
			{
				data.DynamicFormResult = DynamicFormsController.ProcessPropertyValueChanged((Controller)(object)this, dynamicFormPropertyChangedData, data.Parent, text, rootViewItem);
			}
		}
	}

	public static ViewItem FindParentViewItem(ViewItem parentItem, Func<ViewItem, bool> condition)
	{
		if (!(parentItem is RootViewItem rootViewItem) || condition == null)
		{
			return null;
		}
		foreach (ViewItem item in rootViewItem.Items)
		{
			if (condition(item))
			{
				return parentItem;
			}
			ViewItem viewItem = FindParentViewItem(item, condition);
			if (viewItem != null)
			{
				return viewItem;
			}
		}
		return null;
	}

	private IGridData GetGridData(TablePartData data)
	{
		Type typeByUid = IMetadataRuntimeService.GetTypeByUid(data.Data.uid);
		if (typeByUid == null)
		{
			return null;
		}
		return (IGridData)typeof(TablePartController).GetMethod("GetGridDataGeneric", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[1] { typeof(TablePartData) }, null).MakeGenericMethod(typeByUid).Invoke(this, new object[1] { data });
	}

	private IGridData<T> GetGridDataGeneric<T>(TablePartData data)
	{
		bool flag = data.TableView == null || data.TableView.Pageable;
		GridData<T> gridData = new GridData<T>
		{
			Command = data.Data.command,
			JsonDataHiddenFieldId = data.Data.jsonDataHiddenFieldId,
			ParentDataHiddenFieldId = data.Data.parentDataHiddenFieldId,
			JsonData = data.JsonData,
			IsPageable = flag,
			ParentDataObjectId = data.Data.parentDataObjectId,
			ParentDataMetadataUid = data.Data.parentDataMetadataUid,
			EditingRowKeyValue = ((!data.Data.editInPopUp) ? data.Data.editingItem_id : null),
			EditingItemView = data.EditingItemView
		};
		gridData.SortDirection = (data.Data.command.get_SortDescriptors().Any() ? data.Data.command.get_SortDescriptors()[0].get_SortDirection() : ListSortDirection.Ascending);
		gridData.SortExpression = (data.Data.command.get_SortDescriptors().Any() ? data.Data.command.get_SortDescriptors()[0].get_Member() : null);
		gridData.PageSize = ((data.Data.command.get_PageSize() > 1) ? data.Data.command.get_PageSize() : 15);
		if (data.Data.command.get_GroupDescriptors().Any())
		{
			gridData.GroupDescriptors = new List<GridGroupDescriptor>();
			foreach (GroupDescriptor groupDescriptor in data.Data.command.get_GroupDescriptors())
			{
				gridData.GroupDescriptors.Add(new GridGroupDescriptor
				{
					Member = ((SortDescriptor)groupDescriptor).get_Member(),
					SortDirection = ((SortDescriptor)groupDescriptor).get_SortDirection()
				});
			}
		}
		bool result = false;
		IEnumerable<T> enumerable = ((data.Items != null) ? data.Items.OfType<T>() : null);
		int count = enumerable?.Count() ?? 0;
		if (data.Items != null)
		{
			ValueProviderResult value = ((ControllerBase)this).get_ValueProvider().GetValue("exportExcel");
			if (value != null && bool.TryParse(value.get_AttemptedValue(), out result) && result)
			{
				ValueProviderResult value2 = ((ControllerBase)this).get_ValueProvider().GetValue("size");
				if (value2 != null && value2.get_AttemptedValue() != "0")
				{
					result = false;
				}
			}
			enumerable = (IEnumerable<T>)(data.Items = data.Data.command.ApplySorting(enumerable));
			if (flag && data.Data.command.get_PageSize() > 0 && !result)
			{
				int num = ((data.Data.command.get_PageSize() > 0) ? ((enumerable.Count() - 1) / data.Data.command.get_PageSize() + 1) : int.MaxValue);
				if (data.Data.command.get_Page() > num)
				{
					data.Data.command.set_Page((num <= 1) ? 1 : num);
				}
				enumerable = (IEnumerable<T>)(data.Items = data.Data.command.ApplyPaging(enumerable));
			}
			if (data.Data.command.get_GroupDescriptors().Any())
			{
				data.Items = data.Data.command.ApplyGrouping(enumerable);
			}
		}
		gridData.SetData(count, data.Items);
		if (result)
		{
			gridData.SetDataSource((GridData<T> d, FetchOptions f) => data.Items.Cast<object>().Skip(f.FirstResult));
		}
		return gridData;
	}

	private IEntity GetParentObject(ITablePartMetadata metadata, Type itemType, string parentDataObjectId, string parentDataMetadataUid, string parentRootJsonData, bool bindProperties = false)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		if (!string.IsNullOrEmpty(parentDataObjectId) && !string.IsNullOrEmpty(parentDataMetadataUid))
		{
			int num = parentDataObjectId.LastIndexOf(';');
			string idValue = ((num >= 0) ? parentDataObjectId.Substring(num + 1) : parentDataObjectId);
			parentDataObjectId = ((num >= 0) ? parentDataObjectId.Substring(0, num) : null);
			num = parentDataMetadataUid.LastIndexOf(';');
			string input = ((num >= 0) ? parentDataMetadataUid.Substring(num + 1) : parentDataMetadataUid);
			parentDataMetadataUid = ((num >= 0) ? parentDataMetadataUid.Substring(0, num) : null);
			Guid uid = Guid.Parse(input);
			Type typeByUid = IMetadataRuntimeService.GetTypeByUid(uid);
			object id = ModelHelper.TryConvertEntityId(typeByUid, idValue);
			Type entityIdType = ModelHelper.GetEntityIdType(typeByUid);
			IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(typeByUid);
			IEntity parent = ((entityManagerOrNull != null) ? LoadOrCreate(entityManagerOrNull, typeByUid.ConvertId(entityIdType, id)) : null);
			if (parent == null)
			{
				parent = (IEntity)InterfaceActivator.Create(typeByUid);
			}
			if (bindProperties)
			{
				ModelBindingContext val = new ModelBindingContext();
				val.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)(() => parent), typeByUid));
				val.set_ModelName(string.Join(".", "dataItem", "ParentB5857BD3_6DBE_48F0_9489_FD6C08F1528E"));
				val.set_ModelState(new ModelStateDictionary());
				val.set_ValueProvider(((ControllerBase)this).get_ValueProvider());
				ModelBindingContext val2 = val;
				((Controller)this).get_Binders().get_DefaultBinder().BindModel(((ControllerBase)this).get_ControllerContext(), val2);
			}
			ModelBindingContext val3 = new ModelBindingContext();
			val3.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)(() => null), typeof(DynamicFormSettings)));
			val3.set_ModelName("dataItem.__DynamicFormSettings");
			val3.set_ModelState(new ModelStateDictionary());
			val3.set_ValueProvider(((ControllerBase)this).get_ValueProvider());
			ModelBindingContext val4 = val3;
			DynamicFormSettings dynamicFormSettings = (DynamicFormSettings)((Controller)this).get_Binders().get_DefaultBinder().BindModel(((ControllerBase)this).get_ControllerContext(), val4);
			if (dynamicFormSettings != null && !string.IsNullOrEmpty(dynamicFormSettings.ParentFormId))
			{
				string modelName = "dataItem." + dynamicFormSettings.ParentFormId;
				ModelBindingContext val5 = new ModelBindingContext();
				val5.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)(() => parent), parent.GetType()));
				val5.set_ModelName(modelName);
				val5.set_ModelState(new ModelStateDictionary());
				val5.set_ValueProvider(((ControllerBase)this).get_ValueProvider());
				ModelBindingContext val6 = val5;
				((Controller)this).get_Binders().get_DefaultBinder().BindModel(((ControllerBase)this).get_ControllerContext(), val6);
			}
			if (!string.IsNullOrEmpty(parentDataObjectId) && !string.IsNullOrEmpty(parentDataMetadataUid))
			{
				if (MetadataLoader.LoadMetadata(typeByUid) is ITablePartMetadata metadata2)
				{
					IEntity parentObject = GetParentObject(metadata2, typeByUid, parentDataObjectId, parentDataMetadataUid, parentRootJsonData);
					SetParent(parent, metadata2, parentObject);
				}
			}
			else if (!string.IsNullOrEmpty(parentRootJsonData))
			{
				TablePartChangesModel tablePartChangesModel = new JsonSerializer().Deserialize<TablePartChangesModel>(parentRootJsonData);
				if (tablePartChangesModel != null)
				{
					object propertyValue = parent.GetPropertyValue(metadata.TablePartPropertyUid);
					ISet val7 = (ISet)((propertyValue is ISet) ? propertyValue : null);
					if (val7 != null)
					{
						tablePartChangesModel.Apply(val7, itemType);
						foreach (IEntity item in ((IEnumerable)val7).OfType<IEntity>())
						{
							ElmaModelBinder.SetTablePartParent(item, parent);
						}
					}
				}
			}
			return parent;
		}
		return null;
	}

	private void SetParent(IEntity item, ITablePartMetadata metadata, IEntity parent)
	{
		ElmaModelBinder.SetTablePartParent(item, parent);
	}

	private bool HasNonReadOnlyColumns(RootViewItem rootViewItem, ITablePartMetadata tp)
	{
		if (rootViewItem == null || tp == null)
		{
			return false;
		}
		foreach (PropertyMetadata property in tp.Properties)
		{
			PropertyMetadata p2 = property;
			PropertyViewItem propertyViewItem = rootViewItem.FindItem((PropertyViewItem p1) => p1.PropertyUid == p2.Uid);
			if (propertyViewItem != null && !propertyViewItem.IsReadOnly())
			{
				return true;
			}
		}
		if (tp is IEntityMetadata entityMetadata)
		{
			foreach (ITablePartMetadata item in entityMetadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>())
			{
				if (HasNonReadOnlyColumns(rootViewItem, item))
				{
					return true;
				}
			}
		}
		return false;
	}
}

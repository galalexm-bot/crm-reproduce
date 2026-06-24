using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EntityMetadata))]
[FilterType(typeof(IMonitorCacheItemFilter))]
[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[Filterable]
[CacheEntity]
[ImplementationUid("944723a8-bca0-4b4b-b65d-6443b32900fc")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[DisplayName(typeof(__Resources_IMonitorCacheItem), "DisplayName")]
[Uid("2c50de2c-b024-42e4-bb4b-419c2e3d3ace")]
[DisplayFormat(null)]
[Entity("MonitorCacheItem")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>ecff8f1f-7e9a-456f-b7b3-d7d13ce0121b</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
public interface IMonitorCacheItem : IEntity<long>, IEntity, IIdentified
{
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_Uid_DisplayName")]
	[Uid("d75a17d7-1bc4-4ff6-a60e-4dc739d0967c")]
	[EntityProperty]
	[SystemProperty]
	[NotNull]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "da55965d-02a3-4dfd-8b71-d0c45d82c6a5")]
	[Order(1)]
	[Uid("e0ef7208-727b-4381-bb54-881ddfd5b3ab")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_ProcessHeader_DisplayName")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ProcessHeader")]
	IProcessHeader ProcessHeader { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[NotNull]
	[Order(2)]
	[Uid("166163d7-df63-418b-a262-00879b36c8ae")]
	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_CurrentInstanceCount_DisplayName")]
	[Int64Settings(FieldName = "CurrentInstanceCount")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	long CurrentInstanceCount { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("6b6dbc15-1173-4ed3-a9ce-0ed1fdd277e4")]
	[NotNull]
	[Order(3)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_CompletedInstanceCount_DisplayName")]
	[Int64Settings(FieldName = "CompletedInstanceCount")]
	long CompletedInstanceCount { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[NotNull]
	[Order(4)]
	[Uid("eb743745-e227-40c1-acb7-c661aac18e3f")]
	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_TerminatedInstanceCount_DisplayName")]
	[Int64Settings(FieldName = "TerminatedInstanceCount")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	long TerminatedInstanceCount { get; set; }

	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_ActiveTasksCount_DisplayName")]
	[Int64Settings(FieldName = "ActiveTasksCount")]
	[NotNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("9e7d0aad-eca4-461f-8453-cf6ba438868e")]
	[Order(5)]
	long ActiveTasksCount { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Int64Settings(FieldName = "CurrentInstanceEmlCount")]
	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_CurrentInstanceEmlCount_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[NotNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Uid("5068a0df-72c8-4049-a608-0a537594b259")]
	[Order(6)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	long CurrentInstanceEmlCount { get; set; }

	[EntityProperty]
	[NotNull]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(7)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "CompletedInstanceEmlCount")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("84ceae14-ac89-420b-a7da-67ca8af0a71d")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_CompletedInstanceEmlCount_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	long CompletedInstanceEmlCount { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[NotNull]
	[Order(8)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "TerminatedInstanceEmlCount")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("240b5fcd-101d-4ad3-a23a-47cc07f37449")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_TerminatedInstanceEmlCount_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	long TerminatedInstanceEmlCount { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Order(9)]
	[Uid("20e937aa-3114-4fa0-96d7-7dc34fac9647")]
	[Int64Settings(FieldName = "ActiveTasksEmlCount")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[NotNull]
	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_ActiveTasksEmlCount_DisplayName")]
	long ActiveTasksEmlCount { get; set; }

	[Order(10)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("0901edf4-3af3-4756-a7b8-55d016288bc4")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IMonitorCacheItem), "P_User_DisplayName")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	IUser User { get; set; }
}

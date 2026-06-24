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

[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>9c1c20ed-dd98-4271-b408-362ed954ef53</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MonitorUpdateActionQueueItem")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[DisplayName(typeof(__Resources_IMonitorUpdateActionQueueItem), "DisplayName")]
[Uid("7a1a41f2-9d92-4ed3-b42d-74adab1e3191")]
[MetadataType(typeof(EntityMetadata))]
[DisplayFormat(null)]
[ImplementationUid("e3333dcb-6af2-49f7-b09b-0fae6d5e7e90")]
[FilterType(typeof(IMonitorUpdateActionQueueItemFilter))]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
public interface IMonitorUpdateActionQueueItem : IEntity<long>, IEntity, IIdentified
{
	[SystemProperty]
	[Uid("c73b820f-282f-416f-a506-464e1ebf7bb3")]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[EntityProperty]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IMonitorUpdateActionQueueItem), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "CreationDate")]
	[Order(1)]
	[Uid("076612c3-6ad9-4f68-ba88-026bd78d452b")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IMonitorUpdateActionQueueItem), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	DateTime? CreationDate { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Uid("ff5df9d7-4306-43d3-9788-704421095055")]
	[NotNull]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IMonitorUpdateActionQueueItem), "P_ActionTypeUid_DisplayName")]
	[GuidSettings(FieldName = "ActionTypeUid")]
	[Order(2)]
	Guid ActionTypeUid { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "da55965d-02a3-4dfd-8b71-d0c45d82c6a5")]
	[Order(3)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ProcessHeader")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IMonitorUpdateActionQueueItem), "P_ProcessHeader_DisplayName")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Uid("fcab89e0-9fae-4330-b9e5-23fca1964a75")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	IProcessHeader ProcessHeader { get; set; }

	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
	[DisplayName(typeof(__Resources_IMonitorUpdateActionQueueItem), "P_User_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("a514e8bf-c749-4513-80c5-e10ff66d43b3")]
	[Order(4)]
	IUser User { get; set; }

	[DisplayName(typeof(__Resources_IMonitorUpdateActionQueueItem), "P_Executed_DisplayName")]
	[BoolSettings(FieldName = "Executed")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("299738f8-2b45-42d3-952f-a2ee40cc660d")]
	[NotNull]
	[Order(5)]
	bool Executed { get; set; }
}

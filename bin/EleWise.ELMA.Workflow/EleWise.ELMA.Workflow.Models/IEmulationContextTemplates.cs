using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[Entity("EmulationContextTemplates")]
[FilterType(typeof(IEmulationContextTemplatesFilter))]
[ImplementationUid("3da2a62c-a355-4c6c-9c24-f433ea24cd4f")]
[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>265af85c-976a-4832-929b-6fb624ca3b6f</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Filterable]
[MetadataType(typeof(EntityMetadata))]
[Uid("6c201a40-7b3e-4d10-8aef-adc502f16d17")]
[DisplayFormat(null)]
[DisplayName(typeof(__Resources_IEmulationContextTemplates), "DisplayName")]
public interface IEmulationContextTemplates : IEntity<long>, IEntity, IIdentified
{
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[NotNull]
	[DisplayName(typeof(__Resources_IEmulationContextTemplates), "P_Uid_DisplayName")]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[Uid("2e324866-2c6c-45f7-a263-6d8cc1669023")]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IEmulationContextTemplates), "P_Name_DisplayName")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Uid("78c24500-31be-48dc-9c93-ad2b6d196f0d")]
	[Order(1)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringSettings(FieldName = "Name")]
	string Name { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[BlobSettings(FieldName = "Context")]
	[Uid("f19e5bf7-c743-4850-89d4-49ac83a3571a")]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(2)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IEmulationContextTemplates), "P_Context_DisplayName")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	byte[] Context { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(3)]
	[Uid("9c4eab44-6074-4d1f-9ed7-6035566779af")]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IEmulationContextTemplates), "P_UidProcess_DisplayName")]
	[GuidSettings(FieldName = "UidProcess")]
	Guid? UidProcess { get; set; }
}

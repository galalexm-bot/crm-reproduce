using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.KPI.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("047c374c-bb7f-4dd3-aee2-c668f00e05a2")]
[DisplayName(typeof(__Resources_IProjectionScale), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("c951bde4-16f7-40cc-ae77-d33e693194f2")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[DefaultForm(ViewType.Edit, "00000000-0000-0000-0000-000000000000", "4ecb4764-9e95-47c2-b8b0-bcd78da11363", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>e5c14b2a-ab1e-4402-ab76-2554fc9733e7</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ProjectionScale")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[EntityMetadataType(EntityMetadataType.Interface)]
[CopyAction(CopyAction.Clone)]
[Filterable]
[ImplementationUid("36b91e6b-3d4f-42ef-884f-aff25b56c320")]
[FilterType(typeof(IProjectionScaleFilter))]
public interface IProjectionScale : IEntity<long>, IEntity, IIdentified
{
	[Uid("523f05b3-a1d6-4a70-beaf-3ccdf375f9fe")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IProjectionScale), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("c951bde4-16f7-40cc-ae77-d33e693194f2")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[DisplayName(typeof(__Resources_IProjectionScale), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("3a5674c5-fc81-480d-a485-e6f94cffc698")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "4bb45028-4013-426c-919e-ca770fe42edf")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "b3f99aca-b107-471b-a3f1-f4e9340251ee", CascadeMode = CascadeMode.All)]
	[DisplayName(typeof(__Resources_IProjectionScale), "P_Items_DisplayName")]
	[Description(typeof(__Resources_IProjectionScale), "P_Items_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ISet<IProjectionScaleItem> Items { get; set; }

	[Uid("eac95d5c-86c0-4b11-a128-36cc2981e65a")]
	[Order(3)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Holder")]
	[DisplayName(typeof(__Resources_IProjectionScale), "P_Holder_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid Holder { get; set; }

	[Uid("cdb99c90-38fa-4719-a818-02a5b62795ba")]
	[Order(4)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "HolderType")]
	[DisplayName(typeof(__Resources_IProjectionScale), "P_HolderType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	Guid HolderType { get; set; }
}

using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[TitleProperty("57c6de08-e6f6-496f-8690-7eda3e28aff0")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>bd891d96-ee2b-4031-81da-e8d8d2a4c839</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Uid("c2c95235-c01f-48fb-972f-e592d58fdaf0")]
[DisplayName(typeof(__Resources_IRegulationTemplate), "DisplayName")]
[DisplayFormat(null)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("2341907c-eeb5-4133-8b39-352c56c886c3")]
[MetadataType(typeof(EntityMetadata))]
[Entity("RegulationTemplate")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
public interface IRegulationTemplate : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[NotNull]
	[DisplayName(typeof(__Resources_IRegulationTemplate), "P_Uid_DisplayName")]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Uid("c7fae033-6777-4ef5-ab7d-ac1a47ced036")]
	[EntityProperty]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IRegulationTemplate), "P_Name_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[StringRangeLength(0, "2000")]
	[Uid("57c6de08-e6f6-496f-8690-7eda3e28aff0")]
	[Order(1)]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	string Name { get; set; }

	[DisplayName(typeof(__Resources_IRegulationTemplate), "P_FileName_DisplayName")]
	[StringRangeLength(0, "2000")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("8afc2868-9b49-4400-8fa6-ba8e2ee6883a")]
	[Order(2)]
	[StringSettings(MaxValueString = "2000", FieldName = "FileName")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	string FileName { get; set; }

	[Uid("82321fb4-39fb-4550-a346-e271c365f1d8")]
	[StringRangeLength(0, "2000")]
	[StringSettings(MaxValueString = "2000", MultiLine = true, FieldName = "Description")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Order(5)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IRegulationTemplate), "P_Description_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	string Description { get; set; }

	[BinaryFileSettings(FieldName = "File")]
	[Property("289f266b-2805-457e-bce0-b0bcd4d38143")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("da2a3d8d-7653-4ff6-85df-9c7c2db50072")]
	[Order(3)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IRegulationTemplate), "P_File_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	BinaryFile File { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[NotNull]
	[Uid("ced8bee7-e72b-4dcc-8c38-128af4892ea4")]
	[Order(4)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IRegulationTemplate), "P_IsSystem_DisplayName")]
	[BoolSettings(FieldName = "IsSystem")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	bool IsSystem { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IRegulationTemplate), "P_IsDeleted_DisplayName")]
	[Order(6)]
	[Uid("0144bacb-cc05-44dd-b7b1-a7ccc9ef1d01")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[NotNull]
	[BoolSettings(FieldName = "IsDeleted")]
	new bool IsDeleted { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IRegulationTemplate), "P_HardDelete_DisplayName")]
	[BoolSettings(FieldName = "HardDelete")]
	[Order(7)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Uid("6397439a-c052-454f-bee4-6dbd0f9065fa")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	new bool HardDelete { get; set; }
}

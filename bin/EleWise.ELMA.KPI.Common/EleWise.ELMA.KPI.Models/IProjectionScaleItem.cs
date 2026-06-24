using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.KPI.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("4bb45028-4013-426c-919e-ca770fe42edf")]
[DisplayName(typeof(__Resources_IProjectionScaleItem), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("579b6ba7-742e-4424-9eb1-e88d1da6386d")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>a34cd6e0-7637-408f-909b-9cad3496c8da</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ProjectionScaleItem")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("9e35bda7-643d-4357-84a9-c64e24aab0ed")]
[FilterType(typeof(IProjectionScaleItemFilter))]
public interface IProjectionScaleItem : IEntity<long>, IEntity, IIdentified
{
	[Uid("d292b3fb-1ca8-4405-87b0-0ec40f6eca76")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IProjectionScaleItem), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("356e2ab0-23d2-438e-ba36-dad615ca6596")]
	[Order(2)]
	[CanBeNull]
	[Property("d3df6e6e-1ff1-46aa-ad60-d51ffa91ccc7")]
	[DoubleSettings(PrecisionString = null, FieldName = "MinValue")]
	[DisplayName(typeof(__Resources_IProjectionScaleItem), "P_MinValue_DisplayName")]
	[Description(typeof(__Resources_IProjectionScaleItem), "P_MinValue_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	double? MinValue { get; set; }

	[Uid("7d2451e3-acfc-4152-8143-e940b195015a")]
	[Order(3)]
	[CanBeNull]
	[Property("d3df6e6e-1ff1-46aa-ad60-d51ffa91ccc7")]
	[DoubleSettings(PrecisionString = null, FieldName = "MaxValue")]
	[DisplayName(typeof(__Resources_IProjectionScaleItem), "P_MaxValue_DisplayName")]
	[Description(typeof(__Resources_IProjectionScaleItem), "P_MaxValue_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	double? MaxValue { get; set; }

	[Uid("fd8c5f73-2f30-4669-991e-025796a89a7e")]
	[Order(4)]
	[NotNull]
	[Property("d3df6e6e-1ff1-46aa-ad60-d51ffa91ccc7")]
	[DoubleSettings(PrecisionString = null, FieldName = "ResultValue")]
	[DisplayName(typeof(__Resources_IProjectionScaleItem), "P_ResultValue_DisplayName")]
	[Description(typeof(__Resources_IProjectionScaleItem), "P_ResultValue_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	double ResultValue { get; set; }

	[Uid("b3f99aca-b107-471b-a3f1-f4e9340251ee")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "047c374c-bb7f-4dd3-aee2-c668f00e05a2")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ProjectionScale")]
	[DisplayName(typeof(__Resources_IProjectionScaleItem), "P_ProjectionScale_DisplayName")]
	[Description(typeof(__Resources_IProjectionScaleItem), "P_ProjectionScale_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IProjectionScale ProjectionScale { get; set; }

	[Uid("6c77d848-0d89-4ac6-893c-e450d95cc0cb")]
	[Order(6)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(DefaultValue = "#EB7474", FieldName = "Color")]
	[DisplayName(typeof(__Resources_IProjectionScaleItem), "P_Color_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string Color { get; set; }

	[Uid("579b6ba7-742e-4424-9eb1-e88d1da6386d")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[DisplayName(typeof(__Resources_IProjectionScaleItem), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string Name { get; set; }
}

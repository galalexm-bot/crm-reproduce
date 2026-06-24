using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Common.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("3205a29e-9fd2-4eb5-9ba1-2bf23b29c96e")]
[DisplayName(typeof(__Resources_IWpiSelectListItem), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("f7119e36-940b-4f39-afaf-50ccf24b9603")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>a6c26149-9340-46ad-827f-6405d447d96a</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WpiSelectListItem")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("6e41b839-9650-4890-aa73-086f31d96b80")]
public interface IWpiSelectListItem : IEntity<long>, IEntity, IIdentified
{
	[Uid("dfb52ffe-9de8-49b6-99e1-624b733920b6")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IWpiSelectListItem), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("f7119e36-940b-4f39-afaf-50ccf24b9603")]
	[Order(2)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IWpiSelectListItem), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string Name { get; set; }

	[Uid("f112d6bd-b503-4ead-b6cd-f996156ba176")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "b190e242-b38a-4543-a323-77d87cad20c8")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "UnitMeasure")]
	[DisplayName(typeof(__Resources_IWpiSelectListItem), "P_UnitMeasure_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUnitMeasure UnitMeasure { get; set; }

	[Uid("31e9e7b8-9d0f-44a8-953e-94d8e8c23fd5")]
	[Order(3)]
	[NotNull]
	[Required(true)]
	[Property("d3df6e6e-1ff1-46aa-ad60-d51ffa91ccc7")]
	[DoubleSettings(MinValue = 0.0, MaxValue = 100.0, PrecisionString = null, FieldName = "PercentValue")]
	[RequiredField]
	[RangeValue(0.0, 100.0)]
	[DisplayName(typeof(__Resources_IWpiSelectListItem), "P_PercentValue_DisplayName")]
	[Description(typeof(__Resources_IWpiSelectListItem), "P_PercentValue_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	double PercentValue { get; set; }

	[Uid("9cabfb51-2ee9-4772-8212-2b40eed555b9")]
	[Order(4)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDefault")]
	[DisplayName(typeof(__Resources_IWpiSelectListItem), "P_IsDefault_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	bool IsDefault { get; set; }
}

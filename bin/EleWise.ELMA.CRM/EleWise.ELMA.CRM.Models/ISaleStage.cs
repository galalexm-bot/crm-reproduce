using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("01e84b83-0d2b-4b29-85da-377fac2d8fbe")]
[DisplayName(typeof(__Resources_ISaleStage), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("d7f4a81b-0c97-4da4-ab0c-e9b41409d336")]
[ShowInDesigner(false)]
[CustomCode(typeof(ISaleStage), "EleWise.ELMA.CRM.Models.SaleStage.CustomCodeTemplate.cs")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>bc4146b1-c2ca-4368-8660-37b8ca30fcc7</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("SaleStage")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("71b7e249-2a05-47f4-b7d6-04a00f80a020")]
[FilterType(typeof(ISaleStageFilter))]
public interface ISaleStage : IEntity<long>, IEntity, IIdentified
{
	[Obsolete("Это свойство не используется и будет удалено в ближайших версиях", true)]
	bool IsFinal { get; set; }

	[Uid("3bd37a61-7aa6-4df9-9653-8be6dde2e650")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ISaleStage), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("d7f4a81b-0c97-4da4-ab0c-e9b41409d336")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ISaleStage), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[EntityProperty]
	string Name { get; set; }

	[Uid("92dedd28-a59e-425a-88f0-0eaca1d760d7")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "5667c005-cb93-43e0-86ef-8d1bfa437d11")]
	[EntitySettings(CascadeMode = CascadeMode.All, FieldName = "Color")]
	[DisplayName(typeof(__Resources_ISaleStage), "P_Color_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IColor Color { get; set; }

	[Uid("19aceed7-b50c-48e1-a4eb-7ecf967dbddb")]
	[Order(2)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "Probability")]
	[DisplayName(typeof(__Resources_ISaleStage), "P_Probability_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Свойство не используется</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Свойство не используется")]
	[EntityProperty]
	long? Probability { get; set; }

	[Uid("a30769e7-fe6f-438f-8776-194b989362dd")]
	[Order(4)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "3309ace5-b4a3-4895-ba8a-dc69d28b0b27")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "SaleFunnel")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ISaleStage), "P_SaleFunnel_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ISaleFunnel SaleFunnel { get; set; }

	[Uid("015d6018-b422-47ef-baf6-bd78267e7257")]
	[Order(5)]
	[NotNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "GlobalOrder")]
	[DisplayName(typeof(__Resources_ISaleStage), "P_GlobalOrder_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	long GlobalOrder { get; set; }

	[Uid("5c56482f-c35f-4abb-bea6-4a2f6dd5a4a6")]
	[Order(6)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(MinValue = 0L, MaxValue = 100L, FieldName = "Shrinkage")]
	[RangeValue(0, 100)]
	[DisplayName(typeof(__Resources_ISaleStage), "P_Shrinkage_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	long? Shrinkage { get; set; }
}

using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("2c2ae8eb-9f42-4d3e-b990-157357c1a535")]
[DisplayName(typeof(__Resources_IMarketingEffect), "DisplayName")]
[BaseClass("fffdf82c-19fe-4e06-b29e-c7a34b33c4d1")]
[DisplayFormat(null)]
[Image(typeof(IMarketingEffect), "arrow", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>8ff68a3a-df88-454d-aa97-c3507b738c44</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MarketingEffect")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[Filterable]
[ImplementationUid("0158a9af-d13c-425b-bb09-408c03aaeab9")]
[FilterType(typeof(IMarketingEffectFilter))]
[ActionsType(typeof(MarketingEffectActions))]
public interface IMarketingEffect : IMarketingBase, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("e261eb61-aeae-41a4-917e-3626b92afad2")]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53f2d16c-4d27-4891-a3ea-9f8fe7f68a00")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingActivity")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMarketingEffect), "P_MarketingActivity_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IMarketingActivity MarketingActivity { get; set; }

	[Uid("c50f11f4-3c11-43ee-a380-d3124d5bb77e")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "00bcf978-4b09-4d96-8a16-b38199abd32b")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "EffectType")]
	[DisplayName(typeof(__Resources_IMarketingEffect), "P_EffectType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IMarketingEffectType EffectType { get; set; }

	[Uid("288fcf99-8506-4cb7-b61f-3aebb51b72d8")]
	[Order(2)]
	[NotNull]
	[Required(true)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "StartDate")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMarketingEffect), "P_StartDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	DateTime StartDate { get; set; }

	[Uid("6b69a34e-adac-4005-8a44-c5858012ed44")]
	[Order(3)]
	[NotNull]
	[Required(true)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "EndDate")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMarketingEffect), "P_EndDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	DateTime EndDate { get; set; }
}

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
[Uid("0ab5a711-9a14-4da1-a008-e04629a64c43")]
[DisplayName(typeof(__Resources_ISaleProduct), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("61f76bf3-36d0-446d-9847-c448f86b7adb")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[DefaultForm(ViewType.Create, "00000000-0000-0000-0000-000000000000", "084fe756-ebd2-4db9-858a-6fb00a1f068a", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Edit, "00000000-0000-0000-0000-000000000000", "084fe756-ebd2-4db9-858a-6fb00a1f068a", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Display, "00000000-0000-0000-0000-000000000000", "d47fe0d9-cf4b-4a89-8f4d-8028c529628f", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[Form(typeof(ISaleProduct), "EleWise.ELMA.CRM.Models.SaleProduct.Form.Edit.xml")]
[Form(typeof(ISaleProduct), "EleWise.ELMA.CRM.Models.SaleProduct.Form.Display.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>506fdf69-d71e-498d-b169-47c64b7c9696</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("SaleProduct")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("47553c97-664c-468d-a421-33a2115cb060")]
[FilterType(typeof(ISaleProductFilter))]
public interface ISaleProduct : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[Uid("e379dfce-97ba-48de-bbba-e2e14700e4ca")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ISaleProduct), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("dbefc71a-c1fb-459a-923f-0b8ec9c989ea")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "d722eb1b-2583-48e6-ace0-e9417b027804")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Sale")]
	[DisplayName(typeof(__Resources_ISaleProduct), "P_Sale_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ISale Sale { get; set; }

	[Uid("8124089d-c0f6-47d4-8520-bc38d905ef65")]
	[Order(2)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "67c2491f-a196-4b58-b43d-cfd3fa3b0606")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Product")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ISaleProduct), "P_Product_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IProduct Product { get; set; }

	[Uid("2a5e1d1c-d9b7-479a-ac1d-6ae022e203a9")]
	[Order(3)]
	[NotNull]
	[Required(true)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(MinValue = 1L, DefaultValueStr = "1", FieldName = "Quantity")]
	[RequiredField]
	[RangeValue(1L, long.MaxValue)]
	[DisplayName(typeof(__Resources_ISaleProduct), "P_Quantity_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	long Quantity { get; set; }

	[Uid("61f76bf3-36d0-446d-9847-c448f86b7adb")]
	[Order(4)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[CalculateType(PropertyCalculateType.CSScript)]
	[CalculateScript("Product != null ? Product.Name : \"\"")]
	[StringSettings(FieldName = "Name")]
	[DisplayName(typeof(__Resources_ISaleProduct), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[FastSearch(true)]
	[EntityProperty]
	string Name { get; set; }

	[Uid("67d45674-c547-48c1-9732-957a08f2f08a")]
	[Order(5)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_ISaleProduct), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new bool IsDeleted { get; set; }

	[Uid("d2ca4840-617c-49a3-a14f-974bcc297fb8")]
	[Order(6)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	[DisplayName(typeof(__Resources_ISaleProduct), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	new bool HardDelete { get; set; }
}

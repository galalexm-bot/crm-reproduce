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
[Uid("67c2491f-a196-4b58-b43d-cfd3fa3b0606")]
[DisplayName(typeof(__Resources_IProduct), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("907e3749-ee29-4854-8f72-8e52593de117")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[DefaultForm(ViewType.Create, "00000000-0000-0000-0000-000000000000", "bb9c48df-54a8-4da4-b1a5-19bd567b54a2", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Edit, "00000000-0000-0000-0000-000000000000", "bb9c48df-54a8-4da4-b1a5-19bd567b54a2", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Display, "00000000-0000-0000-0000-000000000000", "f8747841-52bf-4bf4-806f-3dab9ba7c10e", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[Form(typeof(IProduct), "EleWise.ELMA.CRM.Models.Product.Form.Edit.xml")]
[Form(typeof(IProduct), "EleWise.ELMA.CRM.Models.Product.Form.Display.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>0ffa7d94-44b9-40b6-9384-c45df8f97143</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Product")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("845380fd-8f1f-4619-b8eb-b25357966f59")]
[Hierarchical(HierarchyType.GroupAndElements, "43e9eaf5-fa80-463a-88af-efa2cbf8dd75", "07025e18-5e8b-47bd-b83c-99ee603c26cb")]
[FilterType(typeof(IProductFilter))]
public interface IProduct : IEntity<long>, IEntity, IIdentified
{
	[Uid("3269b7ae-08ae-4501-a842-b9337d0bf85c")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IProduct), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("43e9eaf5-fa80-463a-88af-efa2cbf8dd75")]
	[Order(1)]
	[SystemProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "67c2491f-a196-4b58-b43d-cfd3fa3b0606")]
	[EntitySettings(FieldName = "Parent")]
	[DisplayName(typeof(__Resources_IProduct), "P_Parent_DisplayName")]
	[EntityProperty]
	IProduct Parent { get; set; }

	[Uid("07025e18-5e8b-47bd-b83c-99ee603c26cb")]
	[Order(2)]
	[NotNull]
	[SystemProperty]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsGroup")]
	[DisplayName(typeof(__Resources_IProduct), "P_IsGroup_DisplayName")]
	[EntityProperty]
	bool IsGroup { get; set; }

	[Uid("907e3749-ee29-4854-8f72-8e52593de117")]
	[Order(3)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IProduct), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("df2ae3f0-4f61-4648-9cc6-ca0256a54eba")]
	[Order(4)]
	[CanBeNull]
	[Property("d3df6e6e-1ff1-46aa-ad60-d51ffa91ccc7")]
	[DoubleSettings(PrecisionString = null, FieldName = "Price")]
	[DisplayName(typeof(__Resources_IProduct), "P_Price_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[ShowInTable(true)]
	[Filterable]
	[EntityProperty]
	double? Price { get; set; }
}

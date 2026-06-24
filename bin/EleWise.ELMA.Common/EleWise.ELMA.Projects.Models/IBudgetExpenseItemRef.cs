using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Projects.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("96c40c48-be33-47c9-ad42-b410ebfc2bec")]
[DisplayName(typeof(__Resources_IBudgetExpenseItemRef), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("df8f7b3e-1af8-4fe5-8797-9d75d5263168")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[DefaultForm(ViewType.Create, "00000000-0000-0000-0000-000000000000", "9a6aff8f-a145-4ebc-9496-cea7beb0dbb6", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Edit, "00000000-0000-0000-0000-000000000000", "dd531e08-97eb-4c81-a5a0-42edc4ba65d7", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Display, "00000000-0000-0000-0000-000000000000", "20f0a970-68b9-4bc3-afb0-5eb5bfd29494", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[Form(typeof(IBudgetExpenseItemRef), "EleWise.ELMA.Common.Models.BudgetExpenseItemRef.Form.CreateForm.xml")]
[Form(typeof(IBudgetExpenseItemRef), "EleWise.ELMA.Common.Models.BudgetExpenseItemRef.Form.EditForm.xml")]
[Form(typeof(IBudgetExpenseItemRef), "EleWise.ELMA.Common.Models.BudgetExpenseItemRef.Form.DisplayForm.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7e0d0fea-8567-4d08-974c-6abe13f2bce2</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[NamespaceForDisplay("EleWise.ELMA.Common.Models")]
[Entity("BudgetExpenseItemRef")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[CopyAction(CopyAction.ByRef)]
[Filterable]
[ImplementationUid("a498a0b5-4edc-4ed8-a992-984ba1a013b0")]
[Hierarchical(HierarchyType.GroupAndElements, "7a674339-c9ad-4c0a-8adf-ff842d7c1039", "f9a5afbb-7e8f-42fb-b9f3-a70f11404420")]
[FilterType(typeof(IBudgetExpenseItemRefFilter))]
public interface IBudgetExpenseItemRef : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[Uid("9edb2668-5d24-4666-ad93-c202f63cdb08")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IBudgetExpenseItemRef), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("7a674339-c9ad-4c0a-8adf-ff842d7c1039")]
	[Order(2)]
	[SystemProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "96c40c48-be33-47c9-ad42-b410ebfc2bec")]
	[EntitySettings(FieldName = "Parent")]
	[DisplayName(typeof(__Resources_IBudgetExpenseItemRef), "P_Parent_DisplayName")]
	[EntityProperty]
	IBudgetExpenseItemRef Parent { get; set; }

	[Uid("f9a5afbb-7e8f-42fb-b9f3-a70f11404420")]
	[Order(1)]
	[NotNull]
	[SystemProperty]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsGroup")]
	[DisplayName(typeof(__Resources_IBudgetExpenseItemRef), "P_IsGroup_DisplayName")]
	[EntityProperty]
	bool IsGroup { get; set; }

	[Uid("df8f7b3e-1af8-4fe5-8797-9d75d5263168")]
	[Order(3)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[RequiredField]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IBudgetExpenseItemRef), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("ad6187d7-e026-4bc3-92ed-c7c3723af019")]
	[Order(4)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Description")]
	[DisplayName(typeof(__Resources_IBudgetExpenseItemRef), "P_Description_DisplayName")]
	[Description(typeof(__Resources_IBudgetExpenseItemRef), "P_Description_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string Description { get; set; }

	[Uid("652d99d2-418d-46f6-b68a-4ed92ba7f960")]
	[Order(5)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_IBudgetExpenseItemRef), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool IsDeleted { get; set; }

	[Uid("7cb24f7f-69d0-4424-9108-088573dd21de")]
	[Order(6)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	[DisplayName(typeof(__Resources_IBudgetExpenseItemRef), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool HardDelete { get; set; }
}

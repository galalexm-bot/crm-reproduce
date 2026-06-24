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
[Uid("2d94c4ee-2299-4a1c-8221-209b2cf98bef")]
[DisplayName(typeof(__Resources_IBudgetIncomeItemRef), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("cc1ce724-d9db-40f0-864d-db47815e3c3b")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[DefaultForm(ViewType.Create, "00000000-0000-0000-0000-000000000000", "f3921875-bbb3-4247-bca2-6944b4151cc3", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Edit, "00000000-0000-0000-0000-000000000000", "827e5888-0483-46fc-a6a6-5196431b66fc", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Display, "00000000-0000-0000-0000-000000000000", "99f883e1-a913-4f65-88ba-f399081848de", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[Form(typeof(IBudgetIncomeItemRef), "EleWise.ELMA.Common.Models.BudgetIncomeItemRef.Form.CreateForm.xml")]
[Form(typeof(IBudgetIncomeItemRef), "EleWise.ELMA.Common.Models.BudgetIncomeItemRef.Form.EditForm.xml")]
[Form(typeof(IBudgetIncomeItemRef), "EleWise.ELMA.Common.Models.BudgetIncomeItemRef.Form.DisplayForm.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>a63a1589-b058-4277-9715-e9ec1c6ac776</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[NamespaceForDisplay("EleWise.ELMA.Common.Models")]
[Entity("BudgetIncomeItemRef")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[CopyAction(CopyAction.ByRef)]
[Filterable]
[ImplementationUid("a5d5bec0-4ae7-4f0d-b5b6-2dfbeedad5a0")]
[Hierarchical(HierarchyType.GroupAndElements, "b000ca5e-3312-4981-a2ac-4faccf800fcf", "d2c728a5-91c1-4fc8-8914-05e8bd9e999a")]
[FilterType(typeof(IBudgetIncomeItemRefFilter))]
public interface IBudgetIncomeItemRef : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[Uid("e6b8de81-8951-4068-8324-d4a140a546ad")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IBudgetIncomeItemRef), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("b000ca5e-3312-4981-a2ac-4faccf800fcf")]
	[Order(2)]
	[SystemProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2d94c4ee-2299-4a1c-8221-209b2cf98bef")]
	[EntitySettings(FieldName = "Parent")]
	[DisplayName(typeof(__Resources_IBudgetIncomeItemRef), "P_Parent_DisplayName")]
	[EntityProperty]
	IBudgetIncomeItemRef Parent { get; set; }

	[Uid("d2c728a5-91c1-4fc8-8914-05e8bd9e999a")]
	[Order(1)]
	[NotNull]
	[SystemProperty]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsGroup")]
	[DisplayName(typeof(__Resources_IBudgetIncomeItemRef), "P_IsGroup_DisplayName")]
	[EntityProperty]
	bool IsGroup { get; set; }

	[Uid("cc1ce724-d9db-40f0-864d-db47815e3c3b")]
	[Order(3)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[RequiredField]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IBudgetIncomeItemRef), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("5a628b3a-511c-4233-a771-b6f41ff8c611")]
	[Order(4)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Description")]
	[DisplayName(typeof(__Resources_IBudgetIncomeItemRef), "P_Description_DisplayName")]
	[Description(typeof(__Resources_IBudgetIncomeItemRef), "P_Description_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string Description { get; set; }

	[Uid("9edd4843-e20d-4fab-a509-c4884c56019d")]
	[Order(5)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_IBudgetIncomeItemRef), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool IsDeleted { get; set; }

	[Uid("4b57f24f-dd7a-40d1-a185-8516cfeb58f0")]
	[Order(6)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	[DisplayName(typeof(__Resources_IBudgetIncomeItemRef), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool HardDelete { get; set; }
}

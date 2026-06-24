using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("bf8a4a39-c878-4ee7-91dd-38f34eb2f836")]
[DisplayName(typeof(__Resources_IMyLegalPerson), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("6f674758-9b87-42d6-b7c5-232d250f1072")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[DefaultForm(ViewType.Create, "00000000-0000-0000-0000-000000000000", "9a627d41-1f23-418f-bdf2-e4ebf13e035d", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Edit, "00000000-0000-0000-0000-000000000000", "9a627d41-1f23-418f-bdf2-e4ebf13e035d", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Display, "00000000-0000-0000-0000-000000000000", "5c8efbe0-1544-4871-8756-e29526b2dde3", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[Form(typeof(IMyLegalPerson), "EleWise.ELMA.Documents.Models.MyLegalPerson.Form.Edit.xml")]
[Form(typeof(IMyLegalPerson), "EleWise.ELMA.Documents.Models.MyLegalPerson.Form.Display.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7643b4bb-5ca6-42e6-8ddd-4dd7e52c8e87</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MyLegalPerson")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("e13b9f1b-b664-432e-b01c-ad060cc0219a")]
[FilterType(typeof(IMyLegalPersonFilter))]
public interface IMyLegalPerson : IEntity<long>, IEntity, IIdentified
{
	[Uid("feb24644-6f12-47e3-8eb6-f3cec296fa7e")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("6f674758-9b87-42d6-b7c5-232d250f1072")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[RequiredField]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[EntityProperty]
	string Name { get; set; }

	[Uid("1dccebf6-d988-4034-ade8-5a8da8fe7c7a")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "JuridicalAddress")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_JuridicalAddress_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string JuridicalAddress { get; set; }

	[Uid("a069c152-a235-4c45-979c-607df5a3d9cc")]
	[Order(3)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Address")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_PostAddress_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string PostAddress { get; set; }

	[Uid("b27487ec-058c-4ec9-9af6-d592aeb86496")]
	[Order(4)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "INN")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_INN_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string INN { get; set; }

	[Uid("2f23bca4-4c65-4987-ba73-7008469b5084")]
	[Order(5)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "KPP")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_KPP_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string KPP { get; set; }

	[Uid("ef129b5b-b021-4d4b-a55c-5d21a88225ea")]
	[Order(6)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "SettlementAccount")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_SettlementAccount_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string SettlementAccount { get; set; }

	[Uid("a69a3f32-d792-4f00-9992-a9bc496d674c")]
	[Order(7)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "LoroAccount")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_LoroAccount_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string LoroAccount { get; set; }

	[Uid("d1a0f819-85fd-4990-b3b1-2e7d8e310a67")]
	[Order(9)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "BIC")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_BIC_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string BIC { get; set; }

	[Uid("1d35b6f8-3159-4e84-a4bf-ea6ea0acf735")]
	[Order(10)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Phone")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_Phone_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string Phone { get; set; }

	[Uid("4fb3c095-49e4-4c5e-b9c7-0dfc3ba89310")]
	[Order(8)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Bank")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_Bank_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string Bank { get; set; }

	[Uid("a0f95a8a-b2ef-4cae-ab9d-aadb4f609e3d")]
	[Order(11)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "HeadOrganizationItem")]
	[DisplayName(typeof(__Resources_IMyLegalPerson), "P_HeadOrganizationItem_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IOrganizationItem HeadOrganizationItem { get; set; }
}

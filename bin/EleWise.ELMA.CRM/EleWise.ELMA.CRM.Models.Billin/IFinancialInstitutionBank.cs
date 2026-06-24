using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[MetadataType(typeof(EntityMetadata))]
[Uid("06213664-8e1d-41eb-8a83-5ebbd4503224")]
[DisplayName(typeof(__Resources_IFinancialInstitutionBank), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("054d6c7d-6618-430e-879a-c4844a176f3a")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[DefaultForm(ViewType.Create, "00000000-0000-0000-0000-000000000000", "c2a3840d-ef98-4ba0-9bcf-35dde6495dc2", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Edit, "00000000-0000-0000-0000-000000000000", "c2a3840d-ef98-4ba0-9bcf-35dde6495dc2", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Display, "00000000-0000-0000-0000-000000000000", "dd18a120-48e1-4914-8986-d4a1b94161f9", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[Form(typeof(IFinancialInstitutionBank), "EleWise.ELMA.CRM.Models.BillingInformation.FinancialInstitutionBank.Form.Edit.xml")]
[Form(typeof(IFinancialInstitutionBank), "EleWise.ELMA.CRM.Models.BillingInformation.FinancialInstitutionBank.Form.Display.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>dcdb10e6-8b1b-4a1a-8dc7-21706d912d57</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("FinancialInstitutionBank")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("1ff9822b-e4f9-4888-b282-57b1ca54a9a9")]
[FilterType(typeof(IFinancialInstitutionBankFilter))]
public interface IFinancialInstitutionBank : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[Uid("033ed124-9e58-4d2f-a7d5-948bce1e20be")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IFinancialInstitutionBank), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("054d6c7d-6618-430e-879a-c4844a176f3a")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IFinancialInstitutionBank), "P_Name_DisplayName")]
	[Description(typeof(__Resources_IFinancialInstitutionBank), "P_Name_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("d2875964-586c-4e9a-9bf6-376ecd6913b7")]
	[Order(2)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "FullName")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IFinancialInstitutionBank), "P_FullName_DisplayName")]
	[Description(typeof(__Resources_IFinancialInstitutionBank), "P_FullName_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string FullName { get; set; }

	[Uid("afe250f9-f049-42f6-923c-b327ccd6ec30")]
	[Order(3)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Location")]
	[DisplayName(typeof(__Resources_IFinancialInstitutionBank), "P_Location_DisplayName")]
	[Description(typeof(__Resources_IFinancialInstitutionBank), "P_Location_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string Location { get; set; }

	[Uid("deff3572-8a49-4448-b621-6a877b9ca7a0")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ac5359a3-7500-49fc-9742-b91378a6d303")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, GenerateFilterInFilter = true, FieldName = "Address")]
	[DisplayName(typeof(__Resources_IFinancialInstitutionBank), "P_Address_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IAddress Address { get; set; }

	[Uid("516db906-4269-4d98-8ad0-d03f27e7c34e")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "58ff3387-8059-41a7-866c-5b231f06eebd")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "e98e182d-88ad-4d17-a531-b525572a28c5", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IFinancialInstitutionBank), "P_BankDetails_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ISet<IBankDetails> BankDetails { get; set; }

	[Uid("1d0a74b8-4333-4930-a8b3-13b989a5d697")]
	[Order(6)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Comment")]
	[DisplayName(typeof(__Resources_IFinancialInstitutionBank), "P_Comment_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string Comment { get; set; }

	[Uid("6195eb51-ee64-47a7-bc74-f4abb039011f")]
	[Order(7)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_IFinancialInstitutionBank), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool IsDeleted { get; set; }

	[Uid("0e5cb9f1-9f6e-4778-9a77-87457a18ce47")]
	[Order(8)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	[DisplayName(typeof(__Resources_IFinancialInstitutionBank), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool HardDelete { get; set; }
}

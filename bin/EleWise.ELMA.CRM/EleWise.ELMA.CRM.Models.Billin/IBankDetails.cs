using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[MetadataType(typeof(EntityMetadata))]
[Uid("58ff3387-8059-41a7-866c-5b231f06eebd")]
[DisplayName(typeof(__Resources_IBankDetails), "DisplayName")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[TitleProperty("91885384-cdb0-4f30-99c8-deb21d137bb4")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[DefaultForm(ViewType.Create, "00000000-0000-0000-0000-000000000000", "119ea14e-bd53-4ada-8616-3797516d0337", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Edit, "00000000-0000-0000-0000-000000000000", "119ea14e-bd53-4ada-8616-3797516d0337", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Display, "00000000-0000-0000-0000-000000000000", "103c2b1b-1d09-4758-830d-8e3583360a5c", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[Form(typeof(IBankDetails), "EleWise.ELMA.CRM.Models.BillingInformation.BankDetails.Form.Edit.xml")]
[Form(typeof(IBankDetails), "EleWise.ELMA.CRM.Models.BillingInformation.BankDetails.Form.Display.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>d20636d2-882a-41a0-9e56-711d8c0abc62</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("BankDetails")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("b69f7a29-0fbc-4c62-b5c2-651e4cf76151")]
[FilterType(typeof(IBankDetailsFilter))]
public interface IBankDetails : IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("f8cf6319-d8a0-4251-80b4-f76c2a2bf8cb")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IBankDetails), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("91885384-cdb0-4f30-99c8-deb21d137bb4")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IBankDetails), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("e98e182d-88ad-4d17-a531-b525572a28c5")]
	[Order(2)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "06213664-8e1d-41eb-8a83-5ebbd4503224")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Bank")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IBankDetails), "P_Bank_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IFinancialInstitutionBank Bank { get; set; }

	[Uid("72b3eddd-0d79-4583-a58e-7abeaeb42be2")]
	[Order(3)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(ShowTime = false, FieldName = "EndDate")]
	[DisplayName(typeof(__Resources_IBankDetails), "P_EndDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DateTime? EndDate { get; set; }

	[Uid("d21545c6-3aec-42ef-93b5-c1351ebd5ba3")]
	[Order(4)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_IBankDetails), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool IsDeleted { get; set; }

	[Uid("ebbd7981-4729-4272-a0b4-e236241a6ec6")]
	[Order(5)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	[DisplayName(typeof(__Resources_IBankDetails), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool HardDelete { get; set; }
}

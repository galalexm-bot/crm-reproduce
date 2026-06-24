using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[MetadataType(typeof(EntityMetadata))]
[Uid("578941e5-5dfe-42c9-911a-f4bda1388169")]
[DisplayName(typeof(__Resources_IPaymentCard), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("db616120-e997-44bb-a406-02e2fe2625b4")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[DefaultForm(ViewType.Create, "00000000-0000-0000-0000-000000000000", "d9817399-20df-442e-9175-20ef82e01fe0", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Edit, "00000000-0000-0000-0000-000000000000", "d9817399-20df-442e-9175-20ef82e01fe0", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Display, "00000000-0000-0000-0000-000000000000", "3263e408-b1b2-4519-b423-2bda116e36a2", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[Form(typeof(IPaymentCard), "EleWise.ELMA.CRM.Models.BillingInformation.PaymentCard.Form.Edit.xml")]
[Form(typeof(IPaymentCard), "EleWise.ELMA.CRM.Models.BillingInformation.PaymentCard.Form.Display.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>6527ce56-0c64-45bc-9937-6c71fffc7df5</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("PaymentCard")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[Filterable]
[ImplementationUid("e2a647f8-5045-4435-9ad9-28a47b055b4e")]
[FilterType(typeof(IPaymentCardFilter))]
public interface IPaymentCard : IEntity<long>, IEntity, IIdentified
{
	[Uid("21ea02c9-5bfb-49a5-a782-c31afb7b5597")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IPaymentCard), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("db616120-e997-44bb-a406-02e2fe2625b4")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IPaymentCard), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("8283d4d0-c1d8-4d2d-a414-27bab8d4dc07")]
	[Order(2)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "4a9b4ddd-efe2-42fc-aab4-39ab26d5c5fd")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "PaymentSystem")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IPaymentCard), "P_PaymentSystem_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IPaymentSystem PaymentSystem { get; set; }

	[Uid("d89864d4-b67a-446f-b73d-89feb0d0585e")]
	[Order(3)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Number")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IPaymentCard), "P_Number_DisplayName")]
	[Description(typeof(__Resources_IPaymentCard), "P_Number_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string Number { get; set; }

	[Uid("5ea43ccf-6d58-40c5-b3f7-ab9a21db520b")]
	[Order(4)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(ShowTime = false, FieldName = "ValidTo")]
	[DisplayName(typeof(__Resources_IPaymentCard), "P_ValidTo_DisplayName")]
	[Description(typeof(__Resources_IPaymentCard), "P_ValidTo_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DateTime? ValidTo { get; set; }

	[Uid("01e65531-4dcd-4175-912d-6d48d0244e6e")]
	[Order(5)]
	[NotNull]
	[Required(true)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "b11f8f16-a2ec-45ae-a8e8-e7aee6c6e444")]
	[EnumSettings(DefaultValueStr = "0a3e253b-8baf-41b3-bbc9-efd77e7be670", FieldName = "Status")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IPaymentCard), "P_Status_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	AccountStatus Status { get; set; }
}

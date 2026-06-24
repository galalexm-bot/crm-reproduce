using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[MetadataType(typeof(EntityMetadata))]
[Uid("8179364c-5105-428a-9c2e-fd8a8d3aaa88")]
[DisplayName(typeof(__Resources_IBankDetailsSWIFT), "DisplayName")]
[BaseClass("58ff3387-8059-41a7-866c-5b231f06eebd")]
[DisplayFormat(null)]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[FormTransformation(typeof(IBankDetailsSWIFT), "EleWise.ELMA.CRM.Models.BillingInformation.BankDetailsSWIFT.Form.Edit.xml")]
[FormTransformation(typeof(IBankDetailsSWIFT), "EleWise.ELMA.CRM.Models.BillingInformation.BankDetailsSWIFT.Form.Display.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>dc361992-4df7-41c7-a25f-ab9e7237ea6f</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("BankDetailsSWIFT")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("c8775dcd-8437-4d6e-98f5-c9a2f7009091")]
[FilterType(typeof(IBankDetailsSWIFTFilter))]
public interface IBankDetailsSWIFT : IBankDetails, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("7f8bb0df-44ae-4519-89f8-defc6204e9a8")]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "NameOfBank")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IBankDetailsSWIFT), "P_NameOfBank_DisplayName")]
	[Description(typeof(__Resources_IBankDetailsSWIFT), "P_NameOfBank_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string NameOfBank { get; set; }

	[Uid("e29249e1-6815-4460-811f-0044bad9a522")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "SWIFTCode")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IBankDetailsSWIFT), "P_SWIFTCode_DisplayName")]
	[Description(typeof(__Resources_IBankDetailsSWIFT), "P_SWIFTCode_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string SWIFTCode { get; set; }

	[Uid("c3a31fc6-7aec-418f-85e6-d54d3a59a653")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "AccountInIntermediaryBank")]
	[DisplayName(typeof(__Resources_IBankDetailsSWIFT), "P_AccountInIntermediaryBank_DisplayName")]
	[Description(typeof(__Resources_IBankDetailsSWIFT), "P_AccountInIntermediaryBank_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string AccountInIntermediaryBank { get; set; }

	[Uid("34d85d02-da1b-402c-b075-85cec093e85d")]
	[Order(3)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "IntermediaryBank")]
	[DisplayName(typeof(__Resources_IBankDetailsSWIFT), "P_IntermediaryBank_DisplayName")]
	[Description(typeof(__Resources_IBankDetailsSWIFT), "P_IntermediaryBank_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string IntermediaryBank { get; set; }
}

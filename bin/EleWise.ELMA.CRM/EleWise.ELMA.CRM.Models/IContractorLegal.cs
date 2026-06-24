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
[Uid("33a33299-1ca2-409a-84f6-901bf91203b6")]
[DisplayName("SR.M('Юридическое лицо')")]
[Description(" ")]
[BaseClass("38096146-0c73-4809-94f5-e18b2d525531")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.CRM.Models.IContactSupport, EleWise.ELMA.CRM")]
[Image(typeof(IContractorLegal), "contractors", 16, ImageFormatType.IconPack, false)]
[CustomCode(typeof(IContractorLegal), "EleWise.ELMA.CRM.Models.ContractorLegal.CustomCodeTemplate.cs")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[Form(typeof(IContractorLegal), "EleWise.ELMA.CRM.Models.ContractorLegal.Form.LeadConverterForm.xml")]
[FormTransformation(typeof(IContractorLegal), "EleWise.ELMA.CRM.Models.ContractorLegal.Form.Display.xml")]
[FormTransformation(typeof(IContractorLegal), "EleWise.ELMA.CRM.Models.ContractorLegal.Form.Edit.xml")]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Display</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <CanUseTabView>true</CanUseTabView>\r\n  <CanUseTabRazorView>true</CanUseTabRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Create</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Edit</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>b4f95601-4683-4d79-90d1-cea62debe5f7</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ContractorLegal")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("3325eab1-fe46-4900-a617-c6fb54ac24c0")]
[FilterType(typeof(IContractorLegalFilter))]
[ActionsType(typeof(ContractorLegalActions))]
public interface IContractorLegal : IContractor, IEntity<long>, IEntity, IIdentified, IMarketingActivityTarget, ISoftDeletable, INextRelationshipEntity, IInheritable, IContactSupport
{
	[Obsolete("Это свойство не используется и будет удалено в ближайших версиях", true)]
	string BANK { get; set; }

	[Obsolete("Это свойство не используется и будет удалено в ближайших версиях", true)]
	string BIK { get; set; }

	[Obsolete("Это свойство не используется и будет удалено в ближайших версиях", true)]
	string RS { get; set; }

	[Obsolete("Это свойство не используется и будет удалено в ближайших версиях", true)]
	string KS { get; set; }

	[Uid("176f489d-ef7e-4ef9-8eef-c14e6b1b4965")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "4b165160-07b7-4e0c-a2d9-75bb05a37824")]
	[EntitySettings(FieldName = "LegalForm")]
	[DisplayName("SR.M('ОПФ')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[ShowInTable(true)]
	[Filterable]
	[EntityProperty]
	ILegalForm LegalForm { get; set; }

	[Uid("7a2f473a-b69b-4277-9a74-7da1d3b14f37")]
	[Order(1)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(MinValue = 0L, FieldName = "Staff")]
	[RangeValue(0L, long.MaxValue)]
	[DisplayName("SR.M('Штат')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[ShowInTable(true)]
	[Filterable]
	[EntityProperty]
	long? Staff { get; set; }

	[Uid("ced01aa3-9dcd-4457-aac4-8e4c50cf5b7c")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "100", FieldName = "OGRN")]
	[StringRangeLength(0, "100")]
	[DisplayName("SR.M('ОГРН')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[FastSearch(true)]
	[ShowInTable(true)]
	[Filterable]
	[EntityProperty]
	string OGRN { get; set; }

	[Uid("34e2746d-1aa7-47ac-bba2-8c4f0ceb2874")]
	[Order(3)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "100", FieldName = "KPP")]
	[StringRangeLength(0, "100")]
	[DisplayName("SR.M('КПП')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[FastSearch(true)]
	[ShowInTable(true)]
	[Filterable]
	[EntityProperty]
	string KPP { get; set; }
}

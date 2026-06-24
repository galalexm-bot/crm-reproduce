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
[Uid("6db85180-fa0f-438a-93e7-bb0a00f02d56")]
[DisplayName(typeof(__Resources_IContractorType), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("b81b9ea7-ac1e-4d29-9299-20380e4d46dd")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[DefaultForm(ViewType.Create, "00000000-0000-0000-0000-000000000000", "63f446fd-cfd5-4693-9a75-239471a66fd0", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Edit, "00000000-0000-0000-0000-000000000000", "63f446fd-cfd5-4693-9a75-239471a66fd0", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[DefaultForm(ViewType.Display, "00000000-0000-0000-0000-000000000000", "846a6a75-71da-4999-b5eb-71ee0209d2c4", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
[Form(typeof(IContractorType), "EleWise.ELMA.CRM.Models.ContractorType.Form.Form.xml")]
[Form(typeof(IContractorType), "EleWise.ELMA.CRM.Models.ContractorType.Form.Form1.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>e4922fe8-9720-4d65-9fff-9d3c0c22f3a0</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ContractorType")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("4dd4556a-cec2-4ec6-b951-40e8aae52fe3")]
public interface IContractorType : IEntity<long>, IEntity, IIdentified
{
	[Uid("8d46dd4d-e845-4b9c-967e-75593debeaa7")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IContractorType), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("b81b9ea7-ac1e-4d29-9299-20380e4d46dd")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IContractorType), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }
}

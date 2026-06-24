using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Diagrams;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Security.Models;

[EntityMetadataType(EntityMetadataType.Interface)]
[MetadataType(typeof(EntityMetadata))]
[Uid("d8723c93-0e32-4859-912c-4256a7d3ee9b")]
[ImplementationUid("a847e9c1-72f1-47e3-b992-05d690b5c7a6")]
[DisplayName(typeof(__Resources_IOrganizationModel), "DisplayName")]
[Description(typeof(__Resources_IOrganizationModel), "Description")]
[Entity("OrganizationModel")]
[TitleProperty("a54381ca-41bc-48b5-8133-7304c8765a81")]
[ShowInCatalogList(false)]
[DisplayFormat("Ver.{Id}")]
[IdType("d6b44bce-b236-424d-aa74-d80da3c8db75")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>698630b9-e398-4dfa-8edc-19349e1be0eb</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
public interface IOrganizationModel : IEntity<int>, IEntity, IIdentified
{
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IOrganizationModel), "P_Uid_DisplayName")]
	[NotNull]
	[Uid("1bbdc9f5-d0bf-4c30-a9d2-9ce2958b5b9a")]
	[SystemProperty]
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	Guid Uid { get; set; }

	[EntityProperty]
	[DisplayName(typeof(__Resources_IOrganizationModel), "P_Diagram_DisplayName")]
	[Property("c977bd31-07d1-4ba2-ab9c-5049d363a923")]
	[Order(2)]
	[Uid("ede12070-0ae2-4ad1-a1cf-e8eb98ebce0c")]
	[OrganizationDiagramTypeSettings(FieldName = "Diagram")]
	OrganizationDiagram Diagram { get; set; }

	[StringRangeLength(0, "255")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[EntityProperty]
	[Uid("2f05ac61-0051-4035-be7f-6f3b2420dfe4")]
	[Order(3)]
	[StringSettings(MaxValueString = "255", MultiLine = true, FieldName = "Description")]
	[DisplayName(typeof(__Resources_IOrganizationModel), "P_Description_DisplayName")]
	string Description { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[NotNull]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("bcc16d1e-b653-4a9f-8dcb-20d76f66e18f")]
	[Order(4)]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DisplayName(typeof(__Resources_IOrganizationModel), "P_CreationDate_DisplayName")]
	[RequiredField]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Required(true)]
	[Description(typeof(__Resources_IOrganizationModel), "P_CreationDate_Description")]
	DateTime CreationDate { get; set; }

	[DisplayName(typeof(__Resources_IOrganizationModel), "P_CreationAuthor_DisplayName")]
	[Description(typeof(__Resources_IOrganizationModel), "P_CreationAuthor_Description")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityUserSettings(FieldName = "CreationAuthor")]
	[Uid("839729f2-5e6a-4627-a1fb-6a617399feff")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	IUser CreationAuthor { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[CalculateType(PropertyCalculateType.CSScript)]
	[FastSearch(true)]
	[Filterable]
	[Order(1)]
	[Required(true)]
	[CalculateScript("Id > 1 ? \"Organization v.\" + (Id - 1) : \"Organization draft\"")]
	[Uid("a54381ca-41bc-48b5-8133-7304c8765a81")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IOrganizationModel), "P_Name_DisplayName")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	string Name { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IOrganizationModel), "P_ChangeDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DateTimeSettings(FieldName = "ChangeDate")]
	[Order(6)]
	[Uid("8d5a1b94-7264-42e8-914b-9630720f8916")]
	[Description(typeof(__Resources_IOrganizationModel), "P_ChangeDate_Description")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[CanBeNull]
	DateTime? ChangeDate { get; set; }

	[Description(typeof(__Resources_IOrganizationModel), "P_ChangeAuthor_Description")]
	[DisplayName(typeof(__Resources_IOrganizationModel), "P_ChangeAuthor_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("8a7d3cf5-80c4-4c94-abf9-f5955d9e5a02")]
	[Order(7)]
	[EntityUserSettings(FieldName = "ChangeAuthor")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	IUser ChangeAuthor { get; set; }

	[OrganizationSubDiagramTypeSettings(FieldName = "SubDiagrams")]
	[DisplayName(typeof(__Resources_IOrganizationModel), "P_SubDiagrams_DisplayName")]
	[Description(typeof(__Resources_IOrganizationModel), "P_SubDiagrams_Description")]
	[Property("1f571770-0498-4192-a076-c987a3a265f8")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("2411b2cd-f507-4616-864f-fd4fd90e4368")]
	[Order(8)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	OrganizationSubDiagram SubDiagrams { get; set; }
}

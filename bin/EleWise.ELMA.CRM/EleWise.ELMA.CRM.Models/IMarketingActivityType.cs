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

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("b021633c-e2bc-4666-8e86-9bb7fa85d54d")]
[DisplayName(typeof(__Resources_IMarketingActivityType), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("553d8c57-f589-47d5-b6ea-d53067292060")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>f9605b9d-f951-4ce1-90c0-a80563850f28</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MarketingActivityType")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("392c99d0-b2bb-4c80-9394-591ed068481f")]
public interface IMarketingActivityType : IEntity<long>, IEntity, IIdentified
{
	[Uid("66f18ff4-c349-4e73-9d67-4c18c9a2fc50")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IMarketingActivityType), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("553d8c57-f589-47d5-b6ea-d53067292060")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMarketingActivityType), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("25ff0cec-90c2-41b0-bac3-01dcd72f5ca1")]
	[Order(2)]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_IMarketingActivityType), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DateTime CreationDate { get; set; }

	[Uid("16a26273-cd50-4152-8eb3-1b2fd9292563")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "CreationAuthor")]
	[DisplayName(typeof(__Resources_IMarketingActivityType), "P_CreationAuthor_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IUser CreationAuthor { get; set; }
}

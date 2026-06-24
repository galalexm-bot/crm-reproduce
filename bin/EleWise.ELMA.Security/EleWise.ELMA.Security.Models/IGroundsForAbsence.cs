using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Security.Models;

[TitleProperty("6dcb9430-bdda-43da-98a1-ff0716d4176c")]
[DisplayFormat(null)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("22110e9d-290a-4801-9de7-9a80caef27dd")]
[ShowInCatalogList(true)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>f6f82f64-bae9-4078-a5fc-719ab65813e7</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("GroundsForAbsence")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Uid("a79c6d13-4dba-4d51-a1e8-3f5a407985e4")]
[MetadataType(typeof(EntityMetadata))]
[FilterType(typeof(IGroundsForAbsenceFilter))]
[DisplayName(typeof(__Resources_IGroundsForAbsence), "DisplayName")]
public interface IGroundsForAbsence : IEntity<long>, IEntity, IIdentified
{
	[Uid("58cf5f27-0c6e-4d1c-8f79-ccf8a99b5e46")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IGroundsForAbsence), "P_Uid_DisplayName")]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[NotNull]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[FastSearch(true)]
	[StringSettings(FieldName = "Name")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[DisplayName(typeof(__Resources_IGroundsForAbsence), "P_Name_DisplayName")]
	[RequiredField]
	[Uid("6dcb9430-bdda-43da-98a1-ff0716d4176c")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Required(true)]
	[Order(1)]
	string Name { get; set; }
}

using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("897ce21d-bcda-4a81-beb0-8a03a5f38716")]
[DisplayName(typeof(__Resources_IDocumentHistoryProfile), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>38be071d-3e4a-4c19-add4-8bf4ab98214b</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DocumentHistoryProfile")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("d69c765c-83d2-48f3-927b-7e2368811482")]
[FilterType(typeof(IDocumentHistoryProfileFilter))]
public interface IDocumentHistoryProfile : IEntity<long>, IEntity, IIdentified
{
	[Uid("c69b8813-0d80-4f98-95d8-8abcf83b6a13")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IDocumentHistoryProfile), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("433fae1e-1d42-4914-a701-7caf2f716af2")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "fb788d2c-3411-4924-98c7-4c3db6a3eecc")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "ef76ac9c-8492-48e9-864e-bb73e4ee8dea", CascadeMode = CascadeMode.SaveUpdate, CopyAction = CopyAction.Clone)]
	[DisplayName(typeof(__Resources_IDocumentHistoryProfile), "P_Chapters_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ISet<IDocumentHistoryChapter> Chapters { get; set; }

	[Uid("a2b3e362-dfcd-422d-b678-2e815bf5ad88")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c3fe0ba3-2b4e-4de7-b60b-45a6fa196cb8")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "DocumentProfile")]
	[DisplayName(typeof(__Resources_IDocumentHistoryProfile), "P_DocumentProfile_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IDocumentMetadataProfile DocumentProfile { get; set; }
}

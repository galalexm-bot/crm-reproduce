using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("a9134459-c58a-4213-a7db-c8cf3d8541c0")]
[DisplayName("SR.M('Набор цветовых схем')")]
[DisplayFormat(null)]
[TableView("\ufeff<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7b941057-ab51-4efb-be68-a25ee87af4c1</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkplaceColorScheme")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("ba7f801a-8043-4b5f-b9c3-b37aca01d700")]
[FilterType(typeof(IWorkplaceColorSchemeFilter))]
public interface IWorkplaceColorScheme : IEntity<long>, IEntity, IIdentified
{
	[Uid("eed842cc-f6ee-49e7-8b6f-4d1037bf7980")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName("SR.M('Уникальный идентификатор')")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("46f0b915-3e51-4c60-8f12-a9f5ff35d163")]
	[Order(1)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "15fcdf05-bcf6-4d38-97cb-51c8086f7bc0")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_WCS_ColorSchemes", ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[RequiredField]
	[DisplayName("SR.M('Цветовые схемы')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ISet<IColorScheme> ColorSchemes { get; set; }
}

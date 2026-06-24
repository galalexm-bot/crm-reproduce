using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Common.Models.Filters;

[MetadataType(typeof(EntityMetadata))]
[Uid("4bf10c6c-4fae-4741-b32b-04fa4879a4d6")]
[DisplayName(typeof(__Resources_IFilter), "DisplayName")]
[BaseClass("9fe78bd1-0b93-49f1-ad7a-1bb196c8c2ee")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Common.Models.Filters.IFilterBase, EleWise.ELMA.Common")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>a25af079-2f0c-45e6-a987-99d30aad11e7</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Filter")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("d1dfde12-b49c-4432-bb54-57b838dcb6d9")]
[FilterType(typeof(IFilterFilter))]
public interface IFilter : IFilterFolder, IEntity<long>, IEntity, IIdentified, IInheritable, IFilterBase
{
	[Uid("80f6a651-db98-4faf-a473-f2e95b7d38bb")]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[XmlSerializableObjectSettings(FieldName = "FilterFields")]
	[DisplayName(typeof(__Resources_IFilter), "P_FilterFields_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	new object FilterFields { get; set; }

	[Uid("59fa3392-fc12-40f9-8aa6-7a83008dba38")]
	[Order(1)]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[XmlSerializableObjectSettings(FieldName = "SearchFields")]
	[DisplayName(typeof(__Resources_IFilter), "P_SearchFields_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	new object SearchFields { get; set; }

	[Uid("92268571-ff9b-473e-b44b-3b9ff0240652")]
	[Order(2)]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[BlobSettings(FieldName = "GridState")]
	[DisplayName(typeof(__Resources_IFilter), "P_GridState_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	new byte[] GridState { get; set; }

	[Uid("b0fac020-ad28-40d8-8e15-d618df2378d0")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ff7da5f9-8007-41ed-80b1-a58d2426a375")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "1bbe0d87-7971-4bd1-b778-41be530a16c5", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IFilter), "P_Permissions_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IFilterPermission> Permissions { get; set; }

	[Uid("3cbb740b-b5c4-4a27-bb52-71380249a925")]
	[Order(4)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "ExpandSearch")]
	[DisplayName(typeof(__Resources_IFilter), "P_ExpandSearch_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new bool ExpandSearch { get; set; }

	[Uid("f8f606c9-9341-492b-b8f7-d154888476f2")]
	[Order(5)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "UseDefaultSettings")]
	[DisplayName(typeof(__Resources_IFilter), "P_UseDefaultSettings_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new bool UseDefaultSettings { get; set; }

	[Uid("1ec3597a-95c2-4265-b916-e07e99c1aa8b")]
	[Order(6)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "UseDefaultSettingsDate")]
	[DisplayName(typeof(__Resources_IFilter), "P_UseDefaultSettingsDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new DateTime? UseDefaultSettingsDate { get; set; }

	[Uid("3237e450-7cec-4d66-a8f8-32b215dbe535")]
	[Order(7)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "ImageUrl")]
	[DisplayName(typeof(__Resources_IFilter), "P_ImageUrl_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new string ImageUrl { get; set; }

	[DisplayName("SR.M('Наименование')")]
	new string Name { get; set; }

	[DisplayName("SR.M('Тип объектов')")]
	new ReferenceOnEntityType ObjectsType { get; set; }

	[DisplayName("SR.M('Код для дополнительного разделения фильтров внутри типа')")]
	new Guid? Code { get; set; }

	new Guid Uid { get; set; }

	[DisplayName("SR.M('Тип фильтра')")]
	new FilterType FilterType { get; set; }
}

using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("0bf0145b-21ae-4184-80eb-f26c967dcce6")]
[DisplayName(typeof(__Resources_ILifeCycleStatus), "DisplayName")]
[DisplayFormat("{$Name}")]
[TitleProperty("a9867bc3-da28-405f-9054-0f101d473710")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>bfc97d14-56c5-4264-8a8a-49edaf33dfdd</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>d1044cc7-e4a5-4a9e-90b0-65615b125c73</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("LifeCycleStatus")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("42302b9a-9d3c-40f9-aa78-5b7671e8732d")]
[CacheEntity]
public interface ILifeCycleStatus : IEntity<long>, IEntity, IIdentified
{
	[Uid("d230c357-a127-43d0-99a4-328a46498250")]
	[NotNull]
	[Required(true)]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ILifeCycleStatus), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("a9867bc3-da28-405f-9054-0f101d473710")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[RequiredField]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_ILifeCycleStatus), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("85a2b160-71aa-4265-8ace-600ef50a7280")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "Description")]
	[DisplayName(typeof(__Resources_ILifeCycleStatus), "P_Description_DisplayName")]
	[EntityProperty]
	string Description { get; set; }

	[Uid("b0adc301-139e-47d9-9fb7-e58cb28c7c33")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "9db1b922-f454-4fad-ab00-02651d1e01c2")]
	[EntitySettings(RelationType = RelationType.ManyToManyInverse, KeyColumnUidStr = "a9b4d686-5e7a-4d29-80d1-881b0f601210", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_ILifeCycleStatus), "P_LifeCycles_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<ILifeCycle> LifeCycles { get; set; }
}

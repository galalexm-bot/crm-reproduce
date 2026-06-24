using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Common.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("23a76a03-b9f3-4218-a937-2d035cdadd4e")]
[DisplayName(typeof(__Resources_IDuplicate), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>aa0ec9c1-5c55-4af2-a35b-cb129d4db654</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Duplicate")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("4a079b9a-ccf2-4509-aaa7-da63c6135327")]
[FilterType(typeof(IDuplicateFilter))]
public interface IDuplicate : IEntity<long>, IEntity, IIdentified
{
	[Uid("abb455a0-4d52-40cd-bcac-83bc0dd7fa6e")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IDuplicate), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("7edd0fbc-e643-43ee-ae1e-52a1c9c40636")]
	[Order(3)]
	[NotNull]
	[Required(true)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "Weight")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IDuplicate), "P_Weight_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	long Weight { get; set; }

	[Uid("1d228a2b-6bc6-4cb5-83ce-396da6049d8a")]
	[Order(4)]
	[Required(true)]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[XmlSerializableObjectSettings(FieldName = "DuplicateFields")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IDuplicate), "P_DuplicateFields_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	object DuplicateFields { get; set; }

	[Uid("59149e3a-f542-4011-bfc4-fbea6809e962")]
	[Order(1)]
	[Required(true)]
	[Property("1f289b26-0607-4bc7-adc0-9ed814c80c90")]
	[ReferenceOnEntitySettings(FieldName = "EntityReference")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IDuplicate), "P_EntityReference_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ReferenceOnEntity EntityReference { get; set; }

	[Uid("8575c98f-5b7a-470a-b57e-51bb7125ffb7")]
	[Order(2)]
	[Required(true)]
	[Property("1f289b26-0607-4bc7-adc0-9ed814c80c90")]
	[ReferenceOnEntitySettings(FieldName = "EntityDuplicateReference")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IDuplicate), "P_EntityDuplicateReference_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ReferenceOnEntity EntityDuplicateReference { get; set; }
}

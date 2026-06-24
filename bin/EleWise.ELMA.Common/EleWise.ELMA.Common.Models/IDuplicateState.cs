using System;
using EleWise.ELMA.Common.Enums;
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
[Uid("e78105b5-8b00-4fb5-8123-6c6fce10a277")]
[DisplayName(typeof(__Resources_IDuplicateState), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>1f723e53-5ab8-4fb6-a827-963cfc5ea611</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DuplicateState")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("603acf48-22d2-4e81-a137-40dd814a3383")]
[FilterType(typeof(IDuplicateStateFilter))]
public interface IDuplicateState : IEntity<long>, IEntity, IIdentified
{
	[Uid("3024e82b-4176-4963-b042-4c72939e0116")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IDuplicateState), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("09a1b4ba-20e7-4b10-95cf-7d969a8432b3")]
	[Order(1)]
	[Property("1f289b26-0607-4bc7-adc0-9ed814c80c90")]
	[ReferenceOnEntitySettings(FieldName = "EntityReference")]
	[DisplayName(typeof(__Resources_IDuplicateState), "P_EntityReference_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ReferenceOnEntity EntityReference { get; set; }

	[Uid("7f103079-7e21-4779-8d07-15ce0b794207")]
	[Order(2)]
	[NotNull]
	[Required(true)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "940cca99-2076-490c-b6e2-a58c3996d936")]
	[EnumSettings(DefaultValueStr = "a65f24ab-f52e-473b-8d0a-103a26a782c6", RelationType = EnumRelationType.Many, FieldName = "DuplicateStatus")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IDuplicateState), "P_DuplicateStatus_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DuplicateStatus DuplicateStatus { get; set; }

	[Uid("8b37143d-8afa-4668-9c3b-5ad4d308183f")]
	[Order(3)]
	[Property("1f289b26-0607-4bc7-adc0-9ed814c80c90")]
	[ReferenceOnEntitySettings(FieldName = "OriginalEntityReference")]
	[DisplayName(typeof(__Resources_IDuplicateState), "P_OriginalEntityReference_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ReferenceOnEntity OriginalEntityReference { get; set; }

	[Uid("0d00c9b1-8b7e-4010-8f84-49b58e04ca36")]
	[Order(4)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "DateOfScoring")]
	[DisplayName(typeof(__Resources_IDuplicateState), "P_DateOfScoring_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DateTime? DateOfScoring { get; set; }
}

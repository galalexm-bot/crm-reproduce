using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("49f88fd3-eda6-43bd-a911-080623bd9920")]
[DisplayName(typeof(__Resources_IDiscussion), "DisplayName")]
[BaseClass("fb88c7e4-586a-40f8-bed6-16b0eeba3a62")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>2fa5fb58-94ab-41bb-afe9-74f333328110</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Discussion")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("d03caa41-b367-412a-b42f-91521034ed79")]
[FilterType(typeof(IDiscussionFilter))]
[ActionsType(typeof(DiscussionActions))]
public interface IDiscussion : IChannelMessage, IBaseMessage, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("676a727c-682f-4aec-bd8b-2c5add800502")]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "EndDate")]
	[DisplayName(typeof(__Resources_IDiscussion), "P_EndDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime? EndDate { get; set; }

	[Uid("ca498dac-23b2-4c24-b46c-3ef4f3360043")]
	[Order(1)]
	[NotNull]
	[Required(true)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "6f1c79a9-e7b6-4d60-b244-72b23f04f67c")]
	[EnumSettings(FieldName = "DiscussionStatus")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IDiscussion), "P_DiscussionStatus_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DiscussionStatus DiscussionStatus { get; set; }
}

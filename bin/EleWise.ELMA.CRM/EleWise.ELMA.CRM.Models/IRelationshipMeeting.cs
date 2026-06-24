using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("3c2696e5-e566-4cc9-9043-c0baa815d6ee")]
[DisplayName("SR.M('Встреча')")]
[BaseClass("ef96d819-d015-4516-b39e-0a8a3c4e337d")]
[DisplayFormat(null)]
[Image(typeof(IRelationshipMeeting), "meeting", 24, ImageFormatType.IconPack, false)]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[Form(typeof(IRelationshipMeeting), "EleWise.ELMA.CRM.Models.RelationshipMeeting.Form.LeadConverterForm.xml")]
[FormTransformation(typeof(IRelationshipMeeting), "EleWise.ELMA.CRM.Models.RelationshipMeeting.Form.BaseView.xml")]
[FormTransformation(typeof(IRelationshipMeeting), "EleWise.ELMA.CRM.Models.RelationshipMeeting.Form.BaseEdit.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>83c38335-ce49-4861-930f-abe320a6c30c</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("RelationshipMeeting")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[Filterable]
[ImplementationUid("ef672d2c-1d14-40d3-b2ac-b132a02c1b6d")]
[FilterType(typeof(IRelationshipMeetingFilter))]
[ActionsType(typeof(RelationshipMeetingActions))]
public interface IRelationshipMeeting : IRelationship, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("b02825fa-6542-4059-a56a-8984f899d3e7")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Place")]
	[DisplayName("SR.M('Место')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Place { get; set; }

	[Uid("3cb9a7aa-33c9-442d-879e-f31579cc4a22")]
	[Order(1)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "TimeNotSet")]
	[DisplayName("SR.M('Уточнить время позже')")]
	[Sortable(false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	bool TimeNotSet { get; set; }
}

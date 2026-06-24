using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("bb66a28f-61bc-42c4-9633-461c2636e2ca")]
[DisplayName("SR.M('Звонок')")]
[Description(" ")]
[BaseClass("ef96d819-d015-4516-b39e-0a8a3c4e337d")]
[DisplayFormat(null)]
[Image(typeof(IRelationshipCall), "call", 16, ImageFormatType.IconPack, false)]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[Form(typeof(IRelationshipCall), "EleWise.ELMA.CRM.Models.RelationshipCall.Form.LeadConverterForm.xml")]
[FormTransformation(typeof(IRelationshipCall), "EleWise.ELMA.CRM.Models.RelationshipCall.Form.BaseView.xml")]
[FormTransformation(typeof(IRelationshipCall), "EleWise.ELMA.CRM.Models.RelationshipCall.Form.BaseEdit.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7a2b38b0-98dc-4a30-865d-81545842571f</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("RelationshipCall")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[ImplementationUid("cdf8842c-3733-43e9-8c55-f74196179a0c")]
[ActionsType(typeof(RelationshipCallActions))]
public interface IRelationshipCall : IRelationship, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("ea005438-f63d-4093-b828-63b4e81f8c57")]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "ef316a2c-96d4-4253-86ad-ff73e7fa8fd3")]
	[EnumSettings(DefaultValueStr = "948a47ce-02cd-47e2-b3fc-80d0823b4ecd", FieldName = "Type")]
	[DisplayName("SR.M('Тип звонка')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	RelationshipCallType Type { get; set; }

	[Uid("9e47f9ba-129a-4070-9509-ac4d6741e4ea")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "UniqueId")]
	[DisplayName("SR.M('Id звонка')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string UniqueId { get; set; }
}

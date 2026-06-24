using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("0261c95e-184d-4160-acab-a26559babf65")]
[DisplayName("SR.M('Документы прикрепленные к базовой задаче')")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[DisplayFormat(null)]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>9144b2c6-f0ab-4549-a30f-cbc054fd4a95</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DocumentAttachments")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
[SaveHistory]
[Filterable]
[FilterType(typeof(IAttachmentsTaskBaseFilter))]
[ActionsType(typeof(AttachmentsTaskBaseActions))]
public interface IAttachmentsTaskBase : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("f30aa369-31c4-4b6d-8b86-d2bc33103946")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "3712c676-4afd-4121-aa1a-4e47ee2e09f8")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_Task_DocumentAttachments", ParentColumnName = "TaskId", ChildColumnName = "DocumentAttachmentId", CascadeMode = CascadeMode.All)]
	[DisplayName("SR.M('Все прикреплённые документы')")]
	[PropertyHandler("53df388f-023d-458e-9d1d-2d72945a6226")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ISet<IDocumentAttachment> DocumentAttachments { get; set; }

	[Uid("934f31d6-73ef-49a9-9d57-2cadf9a45683")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "3712c676-4afd-4121-aa1a-4e47ee2e09f8")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_Task_DAS", ParentColumnName = "TaskId", ChildColumnName = "DocumentAttachmentId", CascadeMode = CascadeMode.All)]
	[DisplayName("SR.M('Прикреплённые документы')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ISet<IDocumentAttachment> DocumentAttachmentsSpecified { get; set; }
}

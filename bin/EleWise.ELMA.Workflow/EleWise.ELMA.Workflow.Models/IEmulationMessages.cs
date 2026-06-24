using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Workflow.Models;

[Uid("6d773946-728a-42e5-bcd6-f1351df8884e")]
[MetadataType(typeof(EntityMetadata))]
[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[FilterType(typeof(IEmulationMessagesFilter))]
[ImplementationUid("fc754c14-9714-49c8-85c2-bb854436c5af")]
[Filterable]
[DisplayFormat(null)]
[Description(typeof(__Resources_IEmulationMessages), "Description")]
[DisplayName(typeof(__Resources_IEmulationMessages), "DisplayName")]
[Entity("EmulationMessages")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c4a0ced7-e843-438a-af40-792fd7ba096c</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ShowInDesigner(false)]
public interface IEmulationMessages : IEntity<long>, IEntity, IIdentified
{
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IEmulationMessages), "P_Uid_DisplayName")]
	[SystemProperty]
	[EntityProperty]
	[GuidSettings(FieldName = "Uid")]
	[NotNull]
	[Uid("a0010c1d-dbee-4e15-a667-bbbc0ebf4a48")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	Guid Uid { get; set; }

	[DisplayName(typeof(__Resources_IEmulationMessages), "P_Subject_DisplayName")]
	[Order(1)]
	[StringSettings(FieldName = "Subject")]
	[Uid("904d0268-0989-47bc-bfa8-b31c0cd63d20")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string Subject { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(2)]
	[Uid("329dc195-1cdd-4916-ba41-cb9f1ffaf0bd")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IEmulationMessages), "P_Text_DisplayName")]
	[StringSettings(FieldName = "Text")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	string Text { get; set; }

	[StringSettings(FieldName = "TextHtml")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[DisplayName(typeof(__Resources_IEmulationMessages), "P_TextHtml_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Uid("fa2af773-487c-4f39-ab28-399c5d4b692e")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(3)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string TextHtml { get; set; }

	[DisplayName(typeof(__Resources_IEmulationMessages), "P_ObjectUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Filterable]
	[GuidSettings(FieldName = "ObjectUid")]
	[Uid("bb8e66b1-f9dc-4b1f-b3b4-7458900cc34f")]
	[Order(4)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[CanBeNull]
	Guid? ObjectUid { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IEmulationMessages), "P_ObjectId_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(5)]
	[Uid("24c32820-5073-4080-b767-46b3421e1b26")]
	[StringSettings(FieldName = "ObjectId")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	string ObjectId { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(6)]
	[Uid("82610be7-d5fa-4bcc-a80d-7ed27457a811")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	[DisplayName(typeof(__Resources_IEmulationMessages), "P_WorkflowInstance_DisplayName")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "WorkflowInstance")]
	IWorkflowInstance WorkflowInstance { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(7)]
	[Uid("f0f7fcb1-b102-420b-abbb-0516044d86c5")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[DisplayName(typeof(__Resources_IEmulationMessages), "P_Recipient_DisplayName")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Recipient")]
	IUser Recipient { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(8)]
	[Uid("0ad7f6b7-4c47-43b1-940c-019471db8118")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c4dc0ccc-c1a3-45d6-b794-e23152342c3d")]
	[DisplayName(typeof(__Resources_IEmulationMessages), "P_Task_DisplayName")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Task")]
	IWorkflowTask Task { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[Uid("b07c57ac-429d-4eeb-8401-619fe1461840")]
	[Order(9)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IEmulationMessages), "P_Recipients_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_EM_Recipients", ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	ISet<IUser> Recipients { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IEmulationMessages), "P_ChannelMessage_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(10)]
	[Uid("c1a5cb68-5720-4026-be60-ada748f2ddb2")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "eb6e8ddc-fafe-4e0e-9018-1a7667012579", FieldName = "ChannelMessage")]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	List<Guid> ChannelMessage { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DateTimeSettings(FieldName = "DateMessage")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IEmulationMessages), "P_DateMessage_DisplayName")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[NotNull]
	[Order(11)]
	[Uid("f74eba74-1fd6-4209-9cb4-7f69de918171")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	DateTime DateMessage { get; set; }
}

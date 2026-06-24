using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Workflow.Models;

[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("WorkflowSwimlaneExecutor")]
[ShowInCatalogList(false)]
[ImplementationUid("6bb4e4a1-3b22-4034-8a16-98e7a14ab86d")]
[EntityMetadataType(EntityMetadataType.Interface)]
[DisplayName(typeof(__Resources_IWorkflowSwimlaneExecutor), "DisplayName")]
[Uid("ab08da75-526a-42f8-9531-bf6cc9c6fb7e")]
[MetadataType(typeof(EntityMetadata))]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>5bc188ca-924b-45de-bdfb-8bc9d80b59b7</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayFormat("{$User}")]
[Description(typeof(__Resources_IWorkflowSwimlaneExecutor), "Description")]
public interface IWorkflowSwimlaneExecutor : IEntity<long>, IEntity, IIdentified
{
	[DisplayName(typeof(__Resources_IWorkflowSwimlaneExecutor), "P_Uid_DisplayName")]
	[GuidSettings(FieldName = "Uid")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[NotNull]
	[Uid("aebf4752-41ac-4e0a-91c1-fe150cd361a3")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[SystemProperty]
	Guid Uid { get; set; }

	[DisplayName(typeof(__Resources_IWorkflowSwimlaneExecutor), "P_WorkflowInstance_DisplayName")]
	[EntityProperty]
	[EntitySettings(FieldName = "WorkflowInstance")]
	[Uid("5d0019d9-68bb-4b4f-8902-25b1a0b1d31d")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	IWorkflowInstance WorkflowInstance { get; set; }

	[GuidSettings(FieldName = "SwimlaneUid")]
	[DisplayName(typeof(__Resources_IWorkflowSwimlaneExecutor), "P_SwimlaneUid_DisplayName")]
	[EntityProperty]
	[Order(1)]
	[Uid("d44001f9-e3f3-4bed-aab1-18e05977952c")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[CanBeNull]
	Guid? SwimlaneUid { get; set; }

	[DisplayName(typeof(__Resources_IWorkflowSwimlaneExecutor), "P_User_DisplayName")]
	[EntityProperty]
	[Order(2)]
	[Uid("df037cd7-21d9-4c6c-9872-5ecaa089bd24")]
	[EntityUserSettings(FieldName = "User")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	IUser User { get; set; }
}

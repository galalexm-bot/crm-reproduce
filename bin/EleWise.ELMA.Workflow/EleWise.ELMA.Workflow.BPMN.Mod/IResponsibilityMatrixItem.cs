using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.BPMN.Models;

[ShowInCatalogList(false)]
[MetadataType(typeof(EntityMetadata))]
[ImplementationUid("24706e05-9bec-404a-ad32-16f17b779cfe")]
[EntityMetadataType(EntityMetadataType.Interface)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "DisplayName")]
[DisplayFormat("Элемент матрицы ответственности")]
[Uid("255f5025-e430-4d28-85e2-93d173070032")]
[Entity("ResponsibilityMatrixItem")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>d2f83ae3-dd88-45b3-8741-8c67270e139c</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
public interface IResponsibilityMatrixItem : IEntity<long>, IEntity, IIdentified
{
	[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Uid("83989d6f-2ffb-4bdd-a132-402a24183257")]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[EntityProperty]
	[NotNull]
	Guid Uid { get; set; }

	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Required(true)]
	[GuidSettings(FieldName = "WorkerType")]
	[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "P_WorkerType_DisplayName")]
	[Uid("ffb33d3d-1d42-4726-8e21-0f09fcc590e4")]
	[RequiredField]
	[EntityProperty]
	[NotNull]
	[Order(1)]
	Guid WorkerType { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "P_WorkerId_DisplayName")]
	[Uid("97f0991d-bede-4547-9c18-bb0544b885be")]
	[Order(2)]
	[CanBeNull]
	[Int64Settings(FieldName = "WorkerId")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	long? WorkerId { get; set; }

	[Required(true)]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[NotNull]
	[Uid("204d9334-f4ec-40af-8201-9c5e07666627")]
	[Order(3)]
	[RequiredField]
	[BoolSettings(FieldName = "Published")]
	[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "P_Published_DisplayName")]
	[EntityProperty]
	bool Published { get; set; }

	[Uid("f840fc44-6123-4bce-88c0-19d24f0478fc")]
	[RequiredField]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsCurator")]
	[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "P_IsCurator_DisplayName")]
	[Order(4)]
	[NotNull]
	[Required(true)]
	[EntityProperty]
	bool IsCurator { get; set; }

	[GuidSettings(FieldName = "SwimlaneUid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[EntityProperty]
	[Order(5)]
	[Uid("eb9b6f64-0314-4d3f-a4ea-2709cdb18c59")]
	[CanBeNull]
	[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "P_SwimlaneUid_DisplayName")]
	Guid? SwimlaneUid { get; set; }

	[RequiredField]
	[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "P_HasStartEvent_DisplayName")]
	[NotNull]
	[EntityProperty]
	[BoolSettings(FieldName = "HasStartEvent")]
	[Uid("fb1531cf-2fab-4b68-9e73-64f864752aaa")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Required(true)]
	[Order(6)]
	bool HasStartEvent { get; set; }

	[RequiredField]
	[BoolSettings(FieldName = "IsDynamic")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "P_IsDynamic_DisplayName")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Order(7)]
	[Uid("86e2588d-cf63-4c42-ac48-6d2094faab55")]
	[Required(true)]
	[NotNull]
	bool IsDynamic { get; set; }

	[Uid("23b8b4ef-15d1-43d6-9a26-6a4c67a7dbdb")]
	[EntitySettings(CascadeMode = CascadeMode.All, FieldName = "BPMNProcess")]
	[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "P_BPMNProcess_DisplayName")]
	[EntityProperty]
	[Order(8)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "3d3fb3b8-ba0d-4f4b-82bb-97b098c2eb6a")]
	IBPMNProcess BPMNProcess { get; set; }

	[EntityProperty]
	[Order(9)]
	[EnumSettings(FieldName = "ResponsibilityLevel")]
	[Uid("24bca70a-5a18-4de1-bb0d-b89abf2f26f3")]
	[DisplayName(typeof(__Resources_IResponsibilityMatrixItem), "P_ResponsibilityLevel_DisplayName")]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "9484ed1e-3f0a-4570-a720-02069600204a")]
	ResponsibilityLevel ResponsibilityLevel { get; set; }
}

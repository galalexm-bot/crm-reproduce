using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[Filterable]
[ImplementationUid("61a63ac7-6189-42b6-9883-4439afaa87f6")]
[ShowInDesigner(false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>211ce36f-0789-4764-999e-d0318fb8e542</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[FilterType(typeof(IMetricValueDataFilter))]
[Entity("MetricValueData")]
[ShowInTypeTree(false)]
[MetadataType(typeof(EntityMetadata))]
[EntityMetadataType(EntityMetadataType.Interface)]
[Uid("b53bd6cd-38ac-4f69-b0d1-d8bb2fd886b8")]
[DisplayFormat(null)]
[DisplayName(typeof(__Resources_IMetricValueData), "DisplayName")]
public interface IMetricValueData : IEntity<long>, IEntity, IIdentified
{
	[SystemProperty]
	[NotNull]
	[Uid("1e306ef6-99b6-4642-8f47-d5a39538cb54")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IMetricValueData), "P_Uid_DisplayName")]
	Guid Uid { get; set; }

	[EntityProperty]
	[Filterable]
	[DisplayName(typeof(__Resources_IMetricValueData), "P_WorkflowInstance_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "WorkflowInstance")]
	[Uid("cbda91fe-31b4-4abc-aa74-51e4bb569870")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	[Order(1)]
	IWorkflowInstance WorkflowInstance { get; set; }

	[EntityProperty]
	[GuidSettings(FieldName = "MetricUid")]
	[Filterable]
	[DisplayName(typeof(__Resources_IMetricValueData), "P_MetricUid_DisplayName")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("f006fa5b-4edf-4ce3-93dd-c034559d3665")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[NotNull]
	[Order(2)]
	Guid MetricUid { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DateTimeSettings(FieldName = "Time")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[CanBeNull]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_IMetricValueData), "P_Time_Description")]
	[DisplayName(typeof(__Resources_IMetricValueData), "P_Time_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("8d423c4d-285b-42f5-b2b2-10f39d4f5374")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(3)]
	DateTime? Time { get; set; }

	[Order(4)]
	[RequiredField]
	[EntityProperty]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", DisplayType = BoolDisplayType.Checkbox, FieldName = "Active")]
	[Required(true)]
	[Uid("afc80409-05c0-4717-8bd6-31d5ca56bd10")]
	[NotNull]
	[DisplayName(typeof(__Resources_IMetricValueData), "P_Active_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	bool Active { get; set; }

	[DateTimeSettings(FieldName = "WarningTime")]
	[DisplayName(typeof(__Resources_IMetricValueData), "P_WarningTime_DisplayName")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[Order(4)]
	[CanBeNull]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("e722e338-4e60-4ac5-886d-a546d12bf39f")]
	DateTime? WarningTime { get; set; }

	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "CriticalTime")]
	[DisplayName(typeof(__Resources_IMetricValueData), "P_CriticalTime_DisplayName")]
	[Uid("be6c3649-04e2-4d12-ae33-26b57f0d7f48")]
	[Order(6)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	DateTime? CriticalTime { get; set; }
}

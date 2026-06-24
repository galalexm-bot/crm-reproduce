using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IWorkflowTaskBase))]
public interface IWorkflowTaskBaseFilter : ITaskBaseFilter, IEntityFilter
{
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Uid("e655a5a7-ae7a-409b-8d57-66626a3913e9")]
	[CustomFilterProperty]
	[NotNull]
	[DisplayName(typeof(__Resources_IWorkflowTaskBase), "FP_InstanceId_DisplayName")]
	[Int64Settings(FieldName = "InstanceId1")]
	long InstanceId { get; set; }

	[DisplayName(typeof(__Resources_IWorkflowTaskBase), "FP_ProcessHeaderId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Order(1)]
	[Uid("0e7de4d5-f509-498e-aff2-60ce0af7a0d8")]
	[CustomFilterProperty]
	[Int64Settings(FieldName = "ProcessHeaderId")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[CanBeNull]
	long? ProcessHeaderId { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Order(2)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("e8292ddf-3846-4021-9b04-61085775bfca")]
	[CustomFilterProperty]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[DisplayName(typeof(__Resources_IWorkflowTaskBase), "FP_ActivityUids_DisplayName")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "eb6e8ddc-fafe-4e0e-9018-1a7667012579", FieldName = "ActivityUids")]
	List<Guid> ActivityUids { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IWorkflowTaskBase), "FP_SwimlaneUid_DisplayName")]
	[Order(3)]
	[CustomFilterProperty]
	[Uid("d3611143-f4f7-4071-9c8c-1f8613749dab")]
	[GuidSettings(FieldName = "SwimlaneUid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[CanBeNull]
	Guid? SwimlaneUid { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[Order(4)]
	[Uid("1b902da3-cac1-42fb-8f70-8cb17efa7dc6")]
	[CustomFilterProperty]
	[DisplayName(typeof(__Resources_IWorkflowTaskBase), "FP_ProcessHeaderIdList_DisplayName")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "ProcessHeaderIdList")]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	List<long> ProcessHeaderIdList { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CustomFilterProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(5)]
	[Uid("e1dce9dc-d735-4ad2-ba7d-8fe27d31b64a")]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	[DisplayName(typeof(__Resources_IWorkflowTaskBase), "FP_InstanceFilter_DisplayName")]
	[AnyTypeSettings(FullTypeName = "EleWise.ELMA.Model.Common.Filter")]
	Filter InstanceFilter { get; set; }
}

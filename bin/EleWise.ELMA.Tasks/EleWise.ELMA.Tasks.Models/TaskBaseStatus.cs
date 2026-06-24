using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Tasks.Models;

[Serializable]
[MetadataType(typeof(EnumMetadata))]
[Uid("b11d6d0a-f07b-40a3-bc49-2cc5a67fbc81")]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "DisplayName")]
[EleWise.ELMA.Model.Attributes.Description(typeof(__Resources_TaskBaseStatus), "Description")]
[EnumMetadataType(EnumMetadataType.ExtendableEnum)]
[TypeConverter(typeof(EnumBaseConverter<TaskBaseStatus>))]
[DefaultValueUid("34387afa-6b70-476f-9d34-748732059003")]
public class TaskBaseStatus : EnumBase
{
	private static TaskBaseStatus _newOrder = new TaskBaseStatus(new Guid("34387afa-6b70-476f-9d34-748732059003"), "NewOrder");

	private static TaskBaseStatus _complete = new TaskBaseStatus(new Guid("dd048b73-4e08-404a-b62e-c55222845cc4"), "Complete");

	private static TaskBaseStatus _incomplete = new TaskBaseStatus(new Guid("1710de4d-86fa-4072-951a-55ebbdcd5bf1"), "Incomplete");

	private static TaskBaseStatus _inProgress = new TaskBaseStatus(new Guid("37a184b8-a81d-4177-9eb5-4ebe3dfae959"), "InProgress");

	private static TaskBaseStatus _wasClosed = new TaskBaseStatus(new Guid("fd7993c6-99c7-4b23-83cc-0f576a63c144"), "WasClosed");

	private static TaskBaseStatus _read = new TaskBaseStatus(new Guid("85707efe-806c-4ec6-8cd6-4d5e4edd8b19"), "Read");

	private static TaskBaseStatus _prepared = new TaskBaseStatus(new Guid("112ea757-36f7-4859-b0d3-6cc0f5a04705"), "Prepared");

	private static TaskBaseStatus _completeControlled = new TaskBaseStatus(new Guid("46f88008-94cd-4b14-985c-31ba6edeb60e"), "CompleteControlled");

	private static TaskBaseStatus _incompleteControlled = new TaskBaseStatus(new Guid("2968382b-e9be-4e2f-967b-0dce0a67a4c4"), "IncompleteControlled");

	private static TaskBaseStatus _onApproval = new TaskBaseStatus(new Guid("b9c9f74a-15ec-4337-9916-f02ffec83dd4"), "OnApproval");

	private static TaskBaseStatus _refuseApproval = new TaskBaseStatus(new Guid("1f6de7ff-03af-401a-a3ca-23af7cab8f65"), "RefuseApproval");

	private static TaskBaseStatus _onApprovalExecutor = new TaskBaseStatus(new Guid("b0b6a339-ba74-4e46-b721-2733d7fb76a9"), "OnApprovalExecutor");

	private static TaskBaseStatus _refuseApprovalExecutor = new TaskBaseStatus(new Guid("70918293-8b84-43be-ad39-181375d51373"), "RefuseApprovalExecutor");

	private static TaskBaseStatus _noComplete = new TaskBaseStatus(new Guid("98ff43bd-b897-41f0-adf2-4eb3b3783851"), "NoComplete");

	private static TaskBaseStatus _completeNeedControl = new TaskBaseStatus(new Guid("b4b74155-53c6-432f-8048-fb9a579349af"), "CompleteNeedControl");

	private static TaskBaseStatus _incompleteNeedControl = new TaskBaseStatus(new Guid("e498da26-0a25-4d99-a053-01dab75db84a"), "IncompleteNeedControl");

	[Uid("34387afa-6b70-476f-9d34-748732059003")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_NewOrder_DisplayName")]
	[Image(typeof(TaskBaseStatus), "star_outline", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus NewOrder => _newOrder;

	[Uid("dd048b73-4e08-404a-b62e-c55222845cc4")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_Complete_DisplayName")]
	[Image(typeof(TaskBaseStatus), "complete", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus Complete => _complete;

	[Uid("1710de4d-86fa-4072-951a-55ebbdcd5bf1")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_Incomplete_DisplayName")]
	[Image(typeof(TaskBaseStatus), "error", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus Incomplete => _incomplete;

	[Uid("37a184b8-a81d-4177-9eb5-4ebe3dfae959")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_InProgress_DisplayName")]
	[Image(typeof(TaskBaseStatus), "task_start", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus InProgress => _inProgress;

	[Uid("fd7993c6-99c7-4b23-83cc-0f576a63c144")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_WasClosed_DisplayName")]
	[Image(typeof(TaskBaseStatus), "close_outline", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus WasClosed => _wasClosed;

	[Uid("85707efe-806c-4ec6-8cd6-4d5e4edd8b19")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_Read_DisplayName")]
	[Image(typeof(TaskBaseStatus), "download", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus Read => _read;

	[Uid("112ea757-36f7-4859-b0d3-6cc0f5a04705")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_Prepared_DisplayName")]
	[View(Visibility.Hidden)]
	[Image(typeof(TaskBaseStatus), "prepared", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus Prepared => _prepared;

	[Uid("46f88008-94cd-4b14-985c-31ba6edeb60e")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_CompleteControlled_DisplayName")]
	[Image(typeof(TaskBaseStatus), "complete_control", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus CompleteControlled => _completeControlled;

	[Uid("2968382b-e9be-4e2f-967b-0dce0a67a4c4")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_IncompleteControlled_DisplayName")]
	[Image(typeof(TaskBaseStatus), "incomplete_control", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus IncompleteControlled => _incompleteControlled;

	[Uid("b9c9f74a-15ec-4337-9916-f02ffec83dd4")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_OnApproval_DisplayName")]
	[Image(typeof(TaskBaseStatus), "complete", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus OnApproval => _onApproval;

	[Uid("1f6de7ff-03af-401a-a3ca-23af7cab8f65")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_RefuseApproval_DisplayName")]
	[Image(typeof(TaskBaseStatus), "error", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus RefuseApproval => _refuseApproval;

	[Uid("b0b6a339-ba74-4e46-b721-2733d7fb76a9")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_OnApprovalExecutor_DisplayName")]
	[Image(typeof(TaskBaseStatus), "complete", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus OnApprovalExecutor => _onApprovalExecutor;

	[Uid("70918293-8b84-43be-ad39-181375d51373")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_RefuseApprovalExecutor_DisplayName")]
	[Image(typeof(TaskBaseStatus), "error", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus RefuseApprovalExecutor => _refuseApprovalExecutor;

	[Uid("98ff43bd-b897-41f0-adf2-4eb3b3783851")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_NoComplete_DisplayName")]
	[Image(typeof(TaskBaseStatus), "task_warning", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus NoComplete => _noComplete;

	[Uid("b4b74155-53c6-432f-8048-fb9a579349af")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_CompleteNeedControl_DisplayName")]
	[Image(typeof(TaskBaseStatus), "complete_need_control", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus CompleteNeedControl => _completeNeedControl;

	[Uid("e498da26-0a25-4d99-a053-01dab75db84a")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskBaseStatus), "P_IncompleteNeedControl_DisplayName")]
	[Image(typeof(TaskBaseStatus), "incomplete_need_control", 16, ImageFormatType.IconPack, false)]
	public static TaskBaseStatus IncompleteNeedControl => _incompleteNeedControl;

	public TaskBaseStatus(Guid value, string name)
		: base(value, name)
	{
	}

	protected TaskBaseStatus(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

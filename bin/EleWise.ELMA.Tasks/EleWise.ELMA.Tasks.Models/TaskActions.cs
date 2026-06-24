using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

public class TaskActions : TaskBaseActions
{
	[Uid("ca7e4640-b9c8-4849-aa55-a9316ce9006a")]
	[DisplayName(typeof(__Resources_TaskActions), "P_ControlComplete_DisplayName")]
	[Image(typeof(TaskActions), "complete", 16, ImageFormatType.IconPack, false)]
	public const string ControlComplete = "ca7e4640-b9c8-4849-aa55-a9316ce9006a";

	private static Guid _controlCompleteGuid = new Guid("ca7e4640-b9c8-4849-aa55-a9316ce9006a");

	[Uid("d9f5a312-270b-4709-b7c8-5789545c4a4c")]
	[DisplayName(typeof(__Resources_TaskActions), "P_Reopen_DisplayName")]
	[Image(typeof(TaskActions), "refresh", 16, ImageFormatType.IconPack, false)]
	public const string Reopen = "d9f5a312-270b-4709-b7c8-5789545c4a4c";

	private static Guid _reopenGuid = new Guid("d9f5a312-270b-4709-b7c8-5789545c4a4c");

	[Uid("2053dfab-43ec-41a3-8069-47de16f75be2")]
	[DisplayName(typeof(__Resources_TaskActions), "P_Close_DisplayName")]
	[Image(typeof(TaskActions), "close_outline", 16, ImageFormatType.IconPack, false)]
	public const string Close = "2053dfab-43ec-41a3-8069-47de16f75be2";

	private static Guid _closeGuid = new Guid("2053dfab-43ec-41a3-8069-47de16f75be2");

	[Uid("059dad1d-bae3-4698-8846-3538711ef82a")]
	[DisplayName(typeof(__Resources_TaskActions), "P_ConfirmApproval_DisplayName")]
	[Image(typeof(TaskActions), "task_complete", 16, ImageFormatType.IconPack, false)]
	public const string ConfirmApproval = "059dad1d-bae3-4698-8846-3538711ef82a";

	private static Guid _confirmApprovalGuid = new Guid("059dad1d-bae3-4698-8846-3538711ef82a");

	[Uid("1c82621a-1f00-4598-861a-5d824891fde4")]
	[DisplayName(typeof(__Resources_TaskActions), "P_RefuseApproval_DisplayName")]
	[Image(typeof(TaskActions), "error", 16, ImageFormatType.IconPack, false)]
	public const string RefuseApproval = "1c82621a-1f00-4598-861a-5d824891fde4";

	private static Guid _refuseApprovalGuid = new Guid("1c82621a-1f00-4598-861a-5d824891fde4");

	[Uid("3a9f7c34-4493-42bd-919d-62bf1f2bbcdb")]
	[DisplayName(typeof(__Resources_TaskActions), "P_ChangeControl_DisplayName")]
	[Image(typeof(TaskActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string ChangeControl = "3a9f7c34-4493-42bd-919d-62bf1f2bbcdb";

	private static Guid _changeControlGuid = new Guid("3a9f7c34-4493-42bd-919d-62bf1f2bbcdb");

	public static Guid ControlCompleteGuid => _controlCompleteGuid;

	public static Guid ReopenGuid => _reopenGuid;

	public static Guid CloseGuid => _closeGuid;

	public static Guid ConfirmApprovalGuid => _confirmApprovalGuid;

	public static Guid RefuseApprovalGuid => _refuseApprovalGuid;

	public static Guid ChangeControlGuid => _changeControlGuid;

	protected TaskActions()
	{
	}
}

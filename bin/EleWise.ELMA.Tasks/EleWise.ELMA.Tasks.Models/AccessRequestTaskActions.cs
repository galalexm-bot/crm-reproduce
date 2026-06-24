using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

public class AccessRequestTaskActions : TaskBaseActions
{
	[Uid("efef3b7c-b5d2-4739-8524-5fc5e192d5c3")]
	[DisplayName("SR.M('В предоставлении доступа отказано')")]
	[Description("SR.M('Выполнить задачу без предоставления запрашиваемого доступа')")]
	[Image(typeof(AccessRequestTaskActions), "error", 16, ImageFormatType.IconPack, false)]
	public const string RefuseAccessRequest = "efef3b7c-b5d2-4739-8524-5fc5e192d5c3";

	private static Guid _refuseAccessRequestGuid = new Guid("efef3b7c-b5d2-4739-8524-5fc5e192d5c3");

	[Uid("15dd5df9-407f-47c5-91d6-67ee2f038e18")]
	[DisplayName("SR.M('Доступ предоставлен')")]
	[Description("SR.M('Выполнить задачу и предоставить запрашиваемый доступ')")]
	[Image(typeof(AccessRequestTaskActions), "task_complete", 16, ImageFormatType.IconPack, false)]
	public const string ApproveAccessRequest = "15dd5df9-407f-47c5-91d6-67ee2f038e18";

	private static Guid _approveAccessRequestGuid = new Guid("15dd5df9-407f-47c5-91d6-67ee2f038e18");

	[Uid("fd199150-2243-4b23-b13b-a33cf3137c51")]
	[DisplayName("SR.M('Закрытие автором')")]
	[Image(typeof(AccessRequestTaskActions), "close_outline", 16, ImageFormatType.IconPack, false)]
	public const string Close = "fd199150-2243-4b23-b13b-a33cf3137c51";

	private static Guid _closeGuid = new Guid("fd199150-2243-4b23-b13b-a33cf3137c51");

	public static Guid RefuseAccessRequestGuid => _refuseAccessRequestGuid;

	public static Guid ApproveAccessRequestGuid => _approveAccessRequestGuid;

	public static Guid CloseGuid => _closeGuid;

	protected AccessRequestTaskActions()
	{
	}
}

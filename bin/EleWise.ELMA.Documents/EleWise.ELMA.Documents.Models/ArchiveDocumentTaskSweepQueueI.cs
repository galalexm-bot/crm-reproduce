using System;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Models;

[Serializable]
internal class ArchiveDocumentTaskSweepQueueItem
{
	public bool Picked { get; set; }

	public DateTime CreationDate { get; set; }

	public long TaskId { get; set; }

	public long UserId { get; set; }

	public string Comment { get; set; }

	public ArchiveDocumentTaskSweepQueueItemStatus Status { get; set; }

	public string Error { get; set; }

	public ITaskBase GetTask()
	{
		ITaskBase task = null;
		Locator.GetService<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			task = EntityManager<ITaskBase>.Instance.LoadOrNull(TaskId);
		});
		return task;
	}

	public EleWise.ELMA.Security.Models.IUser GetUser()
	{
		return EntityManager<EleWise.ELMA.Security.Models.IUser>.Instance.LoadOrNull(UserId);
	}
}
[Serializable]
internal enum ArchiveDocumentTaskSweepQueueItemStatus
{
	None,
	Process,
	Complete
}

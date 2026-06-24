using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints.API;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "Task")]
public class TaskWCF : TaskBaseWCF
{
	[DataMember]
	public bool UnderControl { get; set; }

	[DataMember]
	public TaskControlTypeEnum ControlType { get; set; }

	[DataMember]
	public long ControlUserId { get; set; }

	[DataMember]
	public long[] CurrentControllerIds { get; set; }

	[DataMember]
	public long[] InformToIds { get; set; }

	[DataMember]
	public ParentTaskWCF ParentTask { get; set; }

	[DataMember]
	public ApprovalSubTaskWCF ApprovalTask { get; set; }

	public TaskWCF()
	{
	}

	protected TaskWCF(ITask task, bool needApprovalSubTask)
		: base(task)
	{
		IApprovalTask approvalTask = ((needApprovalSubTask && task.ChildTasks != null) ? ((IEnumerable)task.ChildTasks).OfType<IApprovalTask>().LastOrDefault() : null);
		UnderControl = task.UnderControl;
		ControlUserId = ((task.UnderControl && task.ControlUser != null) ? task.ControlUser.Id : 0);
		ControlType = (TaskControlTypeEnum)task.ControlType;
		InformToIds = ((task.InformTo == null || !((IEnumerable<IUser>)task.InformTo).Any()) ? null : ((IEnumerable<IUser>)task.InformTo).Select((IUser i) => i.Id).ToArray());
		CurrentControllerIds = ((task.CurrentControllers == null || !((IEnumerable<IUser>)task.CurrentControllers).Any()) ? null : ((IEnumerable<IUser>)task.CurrentControllers).Select((IUser i) => i.Id).ToArray());
		ParentTask = ((task.ParentTask == null) ? null : new ParentTaskWCF
		{
			Id = task.ParentTask.Id,
			TypeUid = task.ParentTask.TypeUid,
			Subject = task.ParentTask.Subject
		});
		ApprovalTask = ((approvalTask == null) ? null : new ApprovalSubTaskWCF
		{
			Id = approvalTask.Id,
			Status = (ApprovalStatusEnum)approvalTask.ApprovalStatus,
			Comment = ((IEnumerable<IComment>)approvalTask.Comments).Select((IComment c) => c.Text).LastOrDefault(),
			ApprovalDate = approvalTask.EndWorkDate,
			ExecutorId = approvalTask.Executor.Id
		});
	}

	public static TaskWCF Create(ITask task, bool needApprovalSubTask)
	{
		TaskWCF taskWCF = new TaskWCF(task, needApprovalSubTask);
		ComponentManager.Current.GetExtensionPoints<ITaskWCFFiller>().ForEach(delegate(ITaskWCFFiller p)
		{
			p.FillTaskWCF(task, taskWCF);
		});
		return taskWCF;
	}
}

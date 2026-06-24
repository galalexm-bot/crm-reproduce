using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "ApprovalTask")]
public class ApprovalTaskWCF : TaskBaseWCF
{
	[DataMember]
	public TaskWCF ParentTask { get; set; }

	public ApprovalTaskWCF()
	{
	}

	public ApprovalTaskWCF(IApprovalTask task)
		: base(task)
	{
		ITask task2 = task.ParentTask.CastAsRealType() as ITask;
		ParentTask = ((task2 != null) ? TaskWCF.Create(task2, needApprovalSubTask: false) : null);
	}
}

using System;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public abstract class CreateSimpleSubTaskBase : CreateSubtaskBase
{
	public override Guid SubTaskTypeUid => InterfaceActivator.UID<ITask>();

	public override string SubTaskTypeName => SR.T("Простая задача");

	public override ICreateSubtaskActionModel CreateSettings(ITaskBase parentTask)
	{
		InstanceOf<ICreateSimpleSubtaskActionModel> instanceOf = new InstanceOf<ICreateSimpleSubtaskActionModel>();
		instanceOf.New.ParentId = parentTask.Id;
		instanceOf.New.SubTaskTypeUid = SubTaskTypeUid;
		instanceOf.New.CreateSubTaskAction = "Create";
		instanceOf.New.CreateSubTaskController = "Task";
		instanceOf.New.CreateSubTaskArea = "EleWise.ELMA.BPM.Web.Tasks";
		return instanceOf.New;
	}
}

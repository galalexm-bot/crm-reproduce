using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 10)]
internal class CreateSimpleSubTaskFromWorkflowTask : CreateSimpleSubTaskBase
{
	public override Guid ParentTaskTypeUid => InterfaceActivator.UID<IWorkflowTask>();
}

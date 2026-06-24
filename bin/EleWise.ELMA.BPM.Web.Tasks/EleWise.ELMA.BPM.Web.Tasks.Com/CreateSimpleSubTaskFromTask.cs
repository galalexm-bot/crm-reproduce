using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 10)]
internal class CreateSimpleSubTaskFromTask : CreateSimpleSubTaskBase
{
	public override Guid ParentTaskTypeUid => InterfaceActivator.UID<ITask>();
}

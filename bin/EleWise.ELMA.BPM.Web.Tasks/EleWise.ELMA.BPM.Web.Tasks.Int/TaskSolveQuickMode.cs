using System;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Portlets;

[Component(Order = 10)]
public class TaskSolveQuickMode : ISolveTaskQuickMode
{
	public Guid TypeUid => InterfaceActivator.UID<ITask>();

	public string DisplayName => SR.T("Задачи (поручения)");
}

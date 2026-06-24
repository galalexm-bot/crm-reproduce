using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public class ReAssignTaskActionHandler : IReAssignActionHandler
{
	public void BeforeCreateProcess(object task, IReAssignActionModel model)
	{
		ITask task2 = task as ITask;
		IReAssignTaskActionModel reAssignTaskActionModel = model as IReAssignTaskActionModel;
		if (task2 == null || reAssignTaskActionModel == null)
		{
			return;
		}
		IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		if (reAssignTaskActionModel.SetMeControler)
		{
			task2.UnderControl = true;
			if (task2.ControlType != TaskControlType.Current)
			{
				task2.ControlType = TaskControlType.Execution;
			}
			task2.ControlUser = currentUser;
			TaskManager.Instance.Save(task2);
		}
		else if (reAssignTaskActionModel.SetMeParticipant && !((ICollection<IUser>)task2.InformTo).Contains(currentUser))
		{
			task2.InformTo.Add(currentUser);
			TaskManager.Instance.Save(task2);
		}
		if (reAssignTaskActionModel.TakeCurrentControl && !((ICollection<IUser>)task2.CurrentControllers).Contains(currentUser))
		{
			task2.CurrentControllers.Add(currentUser);
			TaskManager.Instance.Save(task2);
		}
	}
}

using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
internal class DeleteBlockUserReplacementTask : IUnblockUserExtension
{
	[NotNull]
	public ReplacementTaskManager Manager { get; set; }

	public void AfterUnblockUser(IUser user)
	{
		foreach (IReplacementTask task in Manager.GetBlockUserTasksForUser(user))
		{
			Manager.InvokeAction((ReplacementTaskManager m) => m.Close(task.Id, alert: true), typeof(IReplacementTask));
		}
	}
}

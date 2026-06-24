namespace EleWise.ELMA.CAB;

public class SimpleWorkItemActivationService : IWorkItemActivationService
{
	private readonly object syncroot = new object();

	private WorkItem activeWorkItem;

	public void ChangeStatus(WorkItem item)
	{
		lock (syncroot)
		{
			if (item != activeWorkItem && item.Status == WorkItemStatus.Active)
			{
				if (activeWorkItem != null && activeWorkItem.Status != WorkItemStatus.Terminated)
				{
					activeWorkItem.Deactivate();
				}
				activeWorkItem = item;
			}
		}
	}
}

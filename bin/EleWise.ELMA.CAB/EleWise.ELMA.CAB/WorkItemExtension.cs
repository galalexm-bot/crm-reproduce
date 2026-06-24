using System;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB;

public abstract class WorkItemExtension : IWorkItemExtension
{
	private WorkItem workItem;

	public WorkItem WorkItem => workItem;

	public void Initialize(WorkItem workItem)
	{
		Guard.ArgumentNotNull(workItem, "workItem");
		this.workItem = workItem;
		workItem.Activated += OnActivated;
		workItem.Deactivated += OnDeactivated;
		workItem.Initialized += OnInitialized;
		workItem.RunStarted += OnRunStarted;
		workItem.Terminated += OnTerminated;
	}

	private void OnActivated(object sender, EventArgs e)
	{
		OnActivated();
	}

	private void OnDeactivated(object sender, EventArgs e)
	{
		OnDeactivated();
	}

	private void OnInitialized(object sender, EventArgs e)
	{
		OnInitialized();
	}

	private void OnRunStarted(object sender, EventArgs e)
	{
		OnRunStarted();
	}

	private void OnTerminated(object sender, EventArgs e)
	{
		OnTerminated();
	}

	protected virtual void OnActivated()
	{
	}

	protected virtual void OnDeactivated()
	{
	}

	protected virtual void OnInitialized()
	{
	}

	protected virtual void OnRunStarted()
	{
	}

	protected virtual void OnTerminated()
	{
	}
}

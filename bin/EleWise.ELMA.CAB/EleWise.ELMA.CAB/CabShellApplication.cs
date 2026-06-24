namespace EleWise.ELMA.CAB;

public abstract class CabShellApplication<TWorkItem, TShell> : CabApplication<TWorkItem> where TWorkItem : WorkItem, new()
{
	private TShell shell;

	protected TShell Shell => shell;

	protected sealed override void OnRootWorkItemInitialized()
	{
		BeforeShellCreated();
		TWorkItem val = base.RootWorkItem;
		shell = val.Items.AddNew<TShell>();
		AfterShellCreated();
	}

	protected virtual void BeforeShellCreated()
	{
	}

	protected virtual void AfterShellCreated()
	{
	}
}

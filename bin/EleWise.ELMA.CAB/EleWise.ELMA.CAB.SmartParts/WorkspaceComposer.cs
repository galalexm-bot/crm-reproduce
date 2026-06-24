using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.SmartParts;

public class WorkspaceComposer<TSmartPart, TSmartPartInfo> : Workspace<TSmartPart, TSmartPartInfo> where TSmartPartInfo : ISmartPartInfo, new()
{
	private readonly IComposableWorkspace<TSmartPart, TSmartPartInfo> composedWorkspace;

	public WorkspaceComposer(IComposableWorkspace<TSmartPart, TSmartPartInfo> composedWorkspace)
	{
		Guard.ArgumentNotNull(composedWorkspace, "composedWorkspace");
		this.composedWorkspace = composedWorkspace;
		base.SmartPartActivated += OnSmartPartActivatedEvent;
		base.SmartPartClosing += OnSmartPartClosingEvent;
	}

	public void SetActiveSmartPart(TSmartPart smartPart)
	{
		SetActiveSmartPart((object)smartPart);
	}

	public void ForceClose(TSmartPart smartPart)
	{
		CloseInternal(smartPart);
	}

	private void OnSmartPartClosingEvent(object sender, WorkspaceCancelEventArgs e)
	{
		composedWorkspace.RaiseSmartPartClosing(e);
	}

	private void OnSmartPartActivatedEvent(object sender, WorkspaceEventArgs e)
	{
		composedWorkspace.RaiseSmartPartActivated(e);
	}

	protected override void OnActivate(TSmartPart smartPart)
	{
		composedWorkspace.OnActivate(smartPart);
	}

	protected override void OnApplySmartPartInfo(TSmartPart smartPart, TSmartPartInfo smartPartInfo)
	{
		composedWorkspace.OnApplySmartPartInfo(smartPart, smartPartInfo);
	}

	protected override void OnShow(TSmartPart smartPart, TSmartPartInfo smartPartInfo)
	{
		composedWorkspace.OnShow(smartPart, smartPartInfo);
	}

	protected override void OnHide(TSmartPart smartPart)
	{
		composedWorkspace.OnHide(smartPart);
	}

	protected override void OnClose(TSmartPart smartPart)
	{
		composedWorkspace.OnClose(smartPart);
	}

	protected override TSmartPartInfo ConvertFrom(ISmartPartInfo source)
	{
		return composedWorkspace.ConvertFrom(source);
	}
}

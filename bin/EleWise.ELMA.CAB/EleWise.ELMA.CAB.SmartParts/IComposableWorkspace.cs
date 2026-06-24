namespace EleWise.ELMA.CAB.SmartParts;

public interface IComposableWorkspace<TSmartPart, TSmartPartInfo> : IWorkspace where TSmartPartInfo : ISmartPartInfo, new()
{
	void OnActivate(TSmartPart smartPart);

	void OnApplySmartPartInfo(TSmartPart smartPart, TSmartPartInfo smartPartInfo);

	void OnShow(TSmartPart smartPart, TSmartPartInfo smartPartInfo);

	void OnHide(TSmartPart smartPart);

	void OnClose(TSmartPart smartPart);

	void RaiseSmartPartActivated(WorkspaceEventArgs e);

	void RaiseSmartPartClosing(WorkspaceCancelEventArgs e);

	TSmartPartInfo ConvertFrom(ISmartPartInfo source);
}

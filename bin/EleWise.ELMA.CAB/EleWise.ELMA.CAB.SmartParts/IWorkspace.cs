using System;
using System.Collections.ObjectModel;

namespace EleWise.ELMA.CAB.SmartParts;

public interface IWorkspace
{
	ReadOnlyCollection<object> SmartParts { get; }

	object ActiveSmartPart { get; }

	event EventHandler<WorkspaceCancelEventArgs> SmartPartClosing;

	event EventHandler<WorkspaceEventArgs> SmartPartActivated;

	void Activate(object smartPart);

	void ApplySmartPartInfo(object smartPart, ISmartPartInfo smartPartInfo);

	void Close(object smartPart);

	void Hide(object smartPart);

	void Show(object smartPart, ISmartPartInfo smartPartInfo);

	void Show(object smartPart);
}

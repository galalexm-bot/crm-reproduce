using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Diagnostics;

[ExtensionPoint(ComponentType.Server)]
public interface IDiagnosticsEventProcessor
{
	Guid Uid { get; }

	string Name { get; }

	string PerfomanceDegradationMessage { get; }

	void Process(DiagnosticsEvent e);

	void RefreshSettings(EventProcessorsInfo settings, bool diagnosticsEnable);

	object GetDefaultSettings();
}

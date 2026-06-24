using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Diagnostics.Reports;

[ExtensionPoint(ComponentType.All)]
public interface IDiagnosticsReport
{
	Guid Uid { get; }

	string Name { get; }

	string Export();

	void Export(string fileName);
}

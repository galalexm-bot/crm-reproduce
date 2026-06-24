using System;
using System.Diagnostics;

namespace Orchard.Environment;

public class ApplicationEnvironment : IApplicationEnvironment
{
	public string GetEnvironmentIdentifier()
	{
		return $"{System.Environment.MachineName}:{Process.GetCurrentProcess().Id}";
	}
}

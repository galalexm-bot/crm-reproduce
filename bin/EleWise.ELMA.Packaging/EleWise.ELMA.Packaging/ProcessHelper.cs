using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EleWise.ELMA.Packaging;

internal static class ProcessHelper
{
	public static IEnumerable<Process> FindProcesses(string fileName)
	{
		return Process.GetProcesses().Where(delegate(Process p)
		{
			try
			{
				return p.MainModule != null && p.MainModule.FileName != null && p.MainModule.FileName.Equals(fileName, StringComparison.CurrentCultureIgnoreCase);
			}
			catch
			{
				return false;
			}
		}).ToArray();
	}
}

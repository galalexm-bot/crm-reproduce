using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

[Serializable]
public class MyProcessesSettings
{
	private List<long> processHeaders = new List<long>();

	public List<long> ProcessHeaders
	{
		get
		{
			return processHeaders;
		}
		set
		{
			processHeaders = value;
		}
	}
}

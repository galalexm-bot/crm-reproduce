using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Tasks.Models;

[Serializable]
public class AutoSaveWorkLogsUsers
{
	public List<long> UserIds { get; set; }

	public AutoSaveWorkLogsUsers()
	{
		UserIds = new List<long>();
	}
}

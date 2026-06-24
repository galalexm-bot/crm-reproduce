using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

[Serializable]
public class FromMeTasksSettings
{
	[Required(true)]
	public int DaysAgo { get; set; }

	[Required(true)]
	public int DaysAhead { get; set; }

	public bool ShowCompleted { get; set; }

	public static FromMeTasksSettings Default => new FromMeTasksSettings
	{
		DaysAgo = 1,
		DaysAhead = 1,
		ShowCompleted = true
	};
}

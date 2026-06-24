using System.Collections.Generic;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ChangeProcessVersionResponseModel
{
	[StringSettings(MultiLine = true)]
	public string CommentText { get; set; }

	public IList<ExecutorActionRow> ExecutorActions { get; set; }

	public ChangeProcessVersionResponseModel()
	{
		ExecutorActions = new List<ExecutorActionRow>();
	}
}

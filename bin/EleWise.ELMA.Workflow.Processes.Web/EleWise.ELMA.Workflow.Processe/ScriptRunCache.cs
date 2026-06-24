using System;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

[Serializable]
public class ScriptRunCache
{
	public string SelectedScript { get; set; }

	public bool RollbackAfterExecute { get; set; }

	public string Context { get; set; }
}

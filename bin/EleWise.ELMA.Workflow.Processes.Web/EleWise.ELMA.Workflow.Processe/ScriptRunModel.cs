using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ScriptRunModel
{
	public Guid Uid { get; set; }

	public List<string> Scripts { get; set; }

	[Required(true)]
	[RequiredField]
	public string SelectedScript { get; set; }

	public IEntity Context { get; set; }

	public Guid TypeUid { get; set; }

	public string ConsoleMessages { get; set; }

	public bool RollbackAfterExecute { get; set; }

	public Exception ExecutingException { get; set; }

	public IProcessHeader ProcessHeader { get; set; }

	public bool ClearContext { get; set; }

	public ScriptRunModel()
	{
		Scripts = new List<string>();
		RollbackAfterExecute = true;
	}
}

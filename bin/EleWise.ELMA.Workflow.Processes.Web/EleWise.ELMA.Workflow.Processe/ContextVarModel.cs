using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ContextVarModel
{
	public IProcessHeader ProcessHeader { get; set; }

	public Guid ContextVar { get; set; }

	public string ContextVarName
	{
		get
		{
			if (ProcessHeader == null)
			{
				return "";
			}
			if (ContextVar == Guid.Empty)
			{
				return "";
			}
			IPropertyMetadata instanceContextPropertyMetadata = WorkflowInstanceContextService.Instance.GetInstanceContextPropertyMetadata(ProcessHeader.Published, ContextVar);
			if (instanceContextPropertyMetadata == null)
			{
				return "";
			}
			return instanceContextPropertyMetadata.DisplayName;
		}
	}

	public Guid ObjectDescriptor { get; set; }

	public Guid ObjectType { get; set; }

	public string InputName { get; set; }
}

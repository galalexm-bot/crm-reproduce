using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Components;

namespace EleWise.ELMA.Workflow.Processes.Web;

[Component]
public class WorkflowExportExcelIgnoreColumns : IExportExcelIgnoreColumns
{
	private string WorkflowInstanceUniqueName;

	public IEnumerable<string> IgnoreColumnUids
	{
		get
		{
			yield return CustomWorkflowInstanceColumns.Map.UniqueName;
			if (WorkflowInstanceUniqueName == null)
			{
				ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeof(IWorkflowInstanceContext), inherit: false);
				WorkflowInstanceUniqueName = classMetadata.Properties.First((PropertyMetadata p) => p.Name == "WorkflowInstance").UidStr;
			}
			yield return WorkflowInstanceUniqueName;
		}
	}

	public bool Resolve(Type type)
	{
		return type.IsInheritOrSame<IWorkflowInstanceContext>();
	}
}

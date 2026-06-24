using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Extensions;

[InterfaceExtension(typeof(IWorkLogObjectSearchFilter))]
public interface IWorkflowTaskWorkLogObjectSearchFilter : IWorkLogObjectSearchFilter, IAutoImplement, IEntityFilter
{
	[DisplayName(typeof(WorkflowTaskWorkLogItemSearchFilter_SR), "P_ProcessHeader")]
	List<IProcessHeader> ProcessHeaders { get; set; }
}

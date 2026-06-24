using System.Linq;
using System.Text.RegularExpressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component(Order = 100)]
public class WorkflowInstanceCustomSortable : ICustomSortable
{
	private static Regex contextRegex = new Regex("(?<=\\W|^|_)Context(?=\\W|$|_)");

	private static Regex metricValuesRegex = new Regex("(?<=\\W|^|_)MetricValues(?=\\W|$|_)");

	public bool CheckMetadata(ClassMetadata classMetadata, string sortExpression)
	{
		if (string.IsNullOrEmpty(sortExpression))
		{
			return false;
		}
		PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata((IWorkflowInstance m) => m.Context);
		if (classMetadata.Uid == InterfaceActivator.UID<IWorkflowInstance>() || classMetadata.Properties.Any((PropertyMetadata p) => p.Uid == propertyMetadata.Uid))
		{
			if (!contextRegex.IsMatch(sortExpression))
			{
				return metricValuesRegex.IsMatch(sortExpression);
			}
			return true;
		}
		return false;
	}

	public bool IsSortable(ClassMetadata classMetadata, PropertyMetadata metadata)
	{
		return false;
	}

	public string BuildSortExpression(ClassMetadata classMetadata, string sortExpression)
	{
		return string.Empty;
	}
}

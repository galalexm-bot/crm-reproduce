using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;
using NHibernate;

namespace EleWise.ELMA.Workflow.Extensions;

[ExtensionPoint(ComponentType.All)]
public interface IWorflowInstanceSetupFilter
{
	void SetupFilter(ICriteria criteria, IWorkflowInstanceFilter filter, ref bool hasFilteringByMember, ref bool processHeaderJoined);
}

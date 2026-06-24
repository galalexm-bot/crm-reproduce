using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions.PostgreSQL;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Workflow.Extensions;

namespace EleWise.ELMA.Workflow.Db.PostgeSQL;

[Component(Type = ComponentType.Server)]
internal class ObservedContextPropertyUpdateHandler : AbstractObservedContextPropertyUpdateHandler
{
	public ObservedContextPropertyUpdateHandler(IEnumerable<IWorkflowContextPropertyObserver> observers, IRuntimeApplication runtimeApplication)
		: base(observers, runtimeApplication)
	{
	}

	public override void InitComplete()
	{
		if (base.Transform.Uid == PostgreSQLTransformationProvider.ProviderUID)
		{
			base.InitComplete();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Managers;

namespace EleWise.ELMA.IntegrationModules.Workflow.Components;

[Component]
internal sealed class IntegrationLinkedFinder : WorkflowLinkedFinderBase
{
	public IntegrationLinkedFinder(ProcessHeaderManager processHeaderManager)
		: base(processHeaderManager)
	{
	}

	public override FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> objectsToSearch, LinkedObjectsContext context)
	{
		FindLinkedObjectsResult resultObj = new FindLinkedObjectsResult();
		GetProcessDiagrams(objectsToSearch, context).ForEach(delegate(WorkflowDiagram diagram)
		{
			foreach (IntegrationModuleElement element in diagram.Elements.OfType<IntegrationModuleElement>())
			{
				ILinkedObject linkedObject = context.AllObjects.FirstOrDefault((ILinkedObject c) => c.Uid == element.IntegrationModuleHeaderMetadataUid);
				if (linkedObject != null)
				{
					FillObj(resultObj, context, linkedObject.Uid);
				}
			}
		});
		return resultObj;
	}

	protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
	{
		return null;
	}
}

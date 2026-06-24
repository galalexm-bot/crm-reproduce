using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Web.Components.Feed;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Components.Feed;

[Component(Order = 90000)]
public class WorkflowTaskFeedMessageObjectsRenderExtension : FeedMessageObjectsRenderExtension
{
	public override bool IsSupport(Guid objectTypeUid, MessageObject messageObject)
	{
		return MetadataLoader.IsBaseOrChildClass<IWorkflowTask>(objectTypeUid);
	}

	public override string Name(Guid objectTypeUid, MessageObject messageObject)
	{
		if (!MetadataLoader.IsBaseOrChildClass<IWorkflowTask>(objectTypeUid) || !(InterfaceActivator.UID<IWorkflowInstance>(loadImplementation: false) == messageObject.TypeUid))
		{
			return base.Name(objectTypeUid, messageObject);
		}
		return SR.T("Экземпляр процесса");
	}
}

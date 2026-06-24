using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IWorkflowPublicServiceTaskFormExtension
{
	void GetDescriptor(TypeSerializationDescriptorBuilder builder);

	void ToWebData(IWorkflowTaskBase task, WebData webData);
}

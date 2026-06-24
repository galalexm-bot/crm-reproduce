using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ICreateSubtaskFieldVisibility
{
	bool IsDefaultValue(ITaskBase parent, PropertyMetadata property);
}

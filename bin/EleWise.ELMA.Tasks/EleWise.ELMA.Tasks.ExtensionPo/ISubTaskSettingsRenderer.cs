using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ISubTaskSettingsRenderer
{
	bool CanRender(ICreateSubtaskActionModel settings, PropertyMetadata property);

	bool IsSupportedForSubtask(ICreateSubtaskActionModel settings, PropertyMetadata property);

	CreateSubtaskSettingTypes? GetFieldType(ICreateSubtaskActionModel settings, PropertyMetadata property);
}

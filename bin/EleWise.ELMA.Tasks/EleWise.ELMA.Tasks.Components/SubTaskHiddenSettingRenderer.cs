using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
internal class SubTaskHiddenSettingRenderer : SubTaskSettingsRendererBase
{
	public override bool CanRender(ICreateSubtaskActionModel settings, PropertyMetadata property)
	{
		return GetFieldType(settings, property) == CreateSubtaskSettingTypes.HiddenSetting;
	}

	public override bool IsSupportedForSubtask(ICreateSubtaskActionModel settings, PropertyMetadata property)
	{
		return true;
	}
}

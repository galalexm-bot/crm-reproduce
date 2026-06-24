using System;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

public abstract class SubTaskCopySettingsRendererBase : SubTaskSettingsRendererBase
{
	protected abstract string[] UselessSettings { get; }

	protected abstract Guid[] ApplyToSubtaskTypes { get; }

	protected bool IsUselessBoolSetting(ICreateSubtaskActionModel settings, PropertyMetadata property)
	{
		if (ApplyToSubtaskTypes.Contains(settings.SubTaskTypeUid))
		{
			return UselessSettings.Contains(property.Name);
		}
		return false;
	}

	public override bool CanRender(ICreateSubtaskActionModel settings, PropertyMetadata property)
	{
		Type propertyType = settings.GetType().GetProperty(property.Name).PropertyType;
		CreateSubtaskSettingTypes? fieldType = GetFieldType(settings, property);
		bool flag = (ApplyToSubtaskTypes.Length == 0 && UselessSettings.Length == 0) || IsUselessBoolSetting(settings, property);
		return fieldType == CreateSubtaskSettingTypes.CopySetting && propertyType == typeof(bool) && flag;
	}

	public override bool IsSupportedForSubtask(ICreateSubtaskActionModel settings, PropertyMetadata property)
	{
		return !IsUselessBoolSetting(settings, property);
	}
}

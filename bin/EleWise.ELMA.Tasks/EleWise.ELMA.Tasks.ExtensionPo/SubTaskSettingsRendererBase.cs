using System.Linq;
using System.Reflection;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

public abstract class SubTaskSettingsRendererBase : ISubTaskSettingsRenderer
{
	public abstract bool CanRender(ICreateSubtaskActionModel settings, PropertyMetadata property);

	public abstract bool IsSupportedForSubtask(ICreateSubtaskActionModel settings, PropertyMetadata property);

	public virtual CreateSubtaskSettingTypes? GetFieldType(ICreateSubtaskActionModel settings, PropertyMetadata property)
	{
		PropertyInfo propertyInfo = (from a in settings.GetType().GetCustomAttributes(inherit: false).OfType<ImplementAttribute>()
			select a.InterfaceType.GetReflectionProperty(property.Name)).FirstOrDefault((PropertyInfo p) => p != null);
		return ((propertyInfo != null) ? (propertyInfo.GetCustomAttributes(typeof(SubtaskFieldTypeAttribute), inherit: false).FirstOrDefault() as SubtaskFieldTypeAttribute) : null)?.FieldType;
	}
}

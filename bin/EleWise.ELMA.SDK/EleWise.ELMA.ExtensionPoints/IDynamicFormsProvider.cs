using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IDynamicFormsProvider
{
	Guid Uid { get; }

	Type GetEntityType(DynamicFormSettings settings);

	void ExecuteScript(IEntity entity, RootViewItem view, DynamicFormSettings settings, string scriptName, DynamicFormResultData resultData);

	string GetPropertyValueChangeScriptName(IEntity entity, RootViewItem view, DynamicFormSettings settings, string propertyName);
}

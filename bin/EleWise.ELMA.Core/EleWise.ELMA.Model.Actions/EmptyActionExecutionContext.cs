using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Model.Actions;

public sealed class EmptyActionExecutionContext : IActionExecutionContext
{
	private readonly PropertyMetadata propertyMetadata;

	private readonly Func<IController> controller;

	private string actionInfo;

	private readonly ActionExecutionType _003CActionExecutionType_003Ek__BackingField;

	public ActionExecutionType ActionExecutionType => _003CActionExecutionType_003Ek__BackingField;

	public bool IsEmpty => true;

	public EmptyActionExecutionContext()
	{
		_003CActionExecutionType_003Ek__BackingField = ActionExecutionType.Empty;
	}

	public EmptyActionExecutionContext(PropertyMetadata propertyMetadata, Func<IController> controller)
		: this()
	{
		this.propertyMetadata = propertyMetadata;
		this.controller = controller;
	}

	internal string GetActionInfo()
	{
		if (actionInfo != null)
		{
			return actionInfo;
		}
		if (propertyMetadata == null || controller == null)
		{
			actionInfo = "";
			return actionInfo;
		}
		IComponentContainer componentContainer = controller.Invoke()?.Component;
		if (componentContainer == null)
		{
			actionInfo = "";
			return actionInfo;
		}
		actionInfo = SR.T("Свойство: {0}, Компонент: {1}", ((INamedMetadata)propertyMetadata).get_DisplayName(), componentContainer.Name);
		return actionInfo;
	}
}

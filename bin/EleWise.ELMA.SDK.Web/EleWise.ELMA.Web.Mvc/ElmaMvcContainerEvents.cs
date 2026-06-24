using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.Web.Mvc;

[Component]
public class ElmaMvcContainerEvents : IModuleContainerEvents
{
	public void Activated()
	{
		InitMvcValueProviderFactories();
		InitMvcModelBinders();
		InitModelValidators();
	}

	private void InitMvcValueProviderFactories()
	{
		foreach (IValueProviderFactory extensionPoint in ComponentManager.Current.GetExtensionPoints<IValueProviderFactory>())
		{
			((Collection<ValueProviderFactory>)(object)ValueProviderFactories.get_Factories()).Add((ValueProviderFactory)(object)new ValueProviderFactoryWrapper(extensionPoint));
		}
	}

	private void InitModelValidators()
	{
		foreach (IValidatorInfo extensionPoint in ComponentManager.Current.GetExtensionPoints<IValidatorInfo>())
		{
			DataAnnotationsModelValidatorProvider.RegisterAdapter(extensionPoint.AttributeType, extensionPoint.ValidatorType);
		}
	}

	private void InitMvcModelBinders()
	{
		foreach (KeyValuePair<Type, IModelBinder> item in ComponentManager.Current.GetExtensionPoints<IModelBinderProvider>().SelectMany((IModelBinderProvider b) => b.GetModelBinders()))
		{
			if (!ModelBinders.get_Binders().ContainsKey(item.Key))
			{
				ModelBinders.get_Binders().Add(item);
			}
		}
	}

	public void Terminating()
	{
	}
}

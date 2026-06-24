using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Ioc.Abstract;

namespace EleWise.ELMA.Core.React.Components;

[Component(Order = 2147483646)]
public class BaseInputRenderer : BaseReactRenderer
{
	public BaseInputRenderer(ILifetimeScope currentScope)
		: base(currentScope)
	{
	}

	public override bool CanRender(System.Type typeComponent)
	{
		return typeof(IInputComponent).IsAssignableFrom(typeComponent);
	}

	protected override IReactInputModel CreateInputModel(System.Type typeComponent)
	{
		System.Type type = null;
		System.Type[] inputsTypeComponent = GetInputsTypeComponent(typeComponent);
		if (inputsTypeComponent.Length != 0)
		{
			System.Type type2 = inputsTypeComponent[0];
			System.Type typeFromHandle = typeof(BaseInputs<>);
			if (!typeFromHandle.IsAssignableFrom(type2))
			{
				type = typeFromHandle.MakeGenericType(new System.Type[1] { type2 });
			}
		}
		return (IReactInputModel)Activator.CreateInstance(typeof(InputModel<>).MakeGenericType(new System.Type[1] { type }));
	}

	private System.Type[] GetInputsTypeComponent(System.Type typeComponent)
	{
		if (!typeComponent.get_BaseType().get_IsGenericType())
		{
			return GetInputsTypeComponent(typeComponent.get_BaseType());
		}
		return typeComponent.get_BaseType().GetGenericArguments();
	}
}

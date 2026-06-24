using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.React.ExtensionPoints;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Core.UI.Model;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Components;

[Component(Order = 2147483647)]
public class BaseReactRenderer : IReactRenderer
{
	private System.Collections.Generic.IEnumerable<IWrapComponent> wrapComponents;

	private readonly ILifetimeScope currentScope;

	private System.Collections.Generic.IEnumerable<IWrapComponent> WrapComponents => wrapComponents ?? (wrapComponents = ((IScopeContext)currentScope).Resolve<System.Collections.Generic.IEnumerable<IWrapComponent>>());

	public BaseReactRenderer(ILifetimeScope currentScope)
	{
		this.currentScope = currentScope;
	}

	public virtual IRenderContent Render(System.Type typeComponent, IViewModel owner, IInputs inputs = null)
	{
		IReactInputModel inputModel = BaseInitViewModel(typeComponent, owner, inputs);
		return CreateComponent(typeComponent, inputModel);
	}

	public virtual bool CanRender(System.Type typeComponent)
	{
		return typeof(IReactComponent).IsAssignableFrom(typeComponent);
	}

	protected IRenderContent CreateComponent(System.Type typeComponent, IInputModel inputModel)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		IRenderContent val = (IRenderContent)Activator.CreateInstance(typeComponent, new object[1] { inputModel });
		System.Collections.Generic.IEnumerator<IWrapComponent> enumerator = WrapComponents.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				val = enumerator.get_Current().Wrap(val);
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public virtual IReactInputModel BaseInitViewModel(System.Type typeComponent, IViewModel owner, IInputs inputs = null)
	{
		IReactInputModel reactInputModel = CreateInputModel(typeComponent);
		reactInputModel.Key = inputs?.Key ?? typeComponent.get_Name();
		reactInputModel.Inputs = inputs;
		reactInputModel.Owner = owner;
		reactInputModel.RootScope = currentScope;
		reactInputModel.DataStack = owner?.GetDynamicData()?.Clone();
		return reactInputModel;
	}

	protected virtual IReactInputModel CreateInputModel(System.Type typeComponent)
	{
		System.Type inputsType = GetInputsType(typeComponent);
		return (IReactInputModel)Activator.CreateInstance(typeof(InputModel<>).MakeGenericType(new System.Type[1] { inputsType }));
	}

	protected static System.Type GetInputsType(System.Type typeComponent)
	{
		System.Type[] inputsTypes = GetInputsTypes(typeComponent);
		if (inputsTypes.Length != 1)
		{
			return inputsTypes[0];
		}
		return typeof(Inputs);
	}

	private static System.Type[] GetInputsTypes(System.Type typeComponent)
	{
		if (!typeComponent.get_BaseType().get_IsGenericType())
		{
			return GetInputsTypes(typeComponent.get_BaseType());
		}
		return typeComponent.get_BaseType().GetGenericArguments();
	}
}
public abstract class BaseReactRenderer<TComponent, TInputs, TContext> : BaseReactRenderer where TComponent : BaseReactComponent<TInputs, TContext> where TInputs : IInputs where TContext : IContext
{
	protected BaseReactRenderer(ILifetimeScope currentScope)
		: base(currentScope)
	{
	}

	public override bool CanRender(System.Type typeComponent)
	{
		return typeComponent == typeof(TComponent);
	}

	public override IRenderContent Render(System.Type typeComponent, IViewModel owner, IInputs inputs = null)
	{
		return Render(owner, (TInputs)inputs);
	}

	public virtual IRenderContent Render(IViewModel owner, TInputs inputs)
	{
		System.Type typeFromHandle = typeof(TComponent);
		TInputs val = InitViewModel(inputs);
		IReactInputModel inputModel = BaseInitViewModel(typeFromHandle, owner, val);
		return CreateComponent(typeFromHandle, inputModel);
	}

	protected IReactInputModel<TInputs> CreateInputModel()
	{
		return (InputModel<TInputs>)Activator.CreateInstance(typeof(InputModel<>).MakeGenericType(new System.Type[1] { typeof(TInputs) }));
	}

	protected virtual TInputs InitViewModel(TInputs inputs)
	{
		return inputs;
	}
}

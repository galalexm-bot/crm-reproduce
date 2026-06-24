using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.Model;
using EleWise.ELMA.Core.React.ExtensionPoints;
using EleWise.ELMA.Core.React.Helpers;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Core.React.Services;
using EleWise.ELMA.Core.UI.Model;
using EleWise.ELMA.Core.UI.Renderers;
using EleWise.ELMA.Core.UI.Services;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Components;

[Component]
public abstract class ViewItemRenderer<TViewItem, TComponent, TInputs, TContext, TController> : ViewItemRenderer where TViewItem : ViewItem where TComponent : BaseViewItemComponent<TViewItem, TInputs, TContext, TController> where TInputs : IInputs where TContext : IContext where TController : IController
{
	protected ViewItemRenderer(ILifetimeScope currentScope)
		: base(currentScope)
	{
	}

	public virtual bool CanRender(TViewItem viewItem)
	{
		return ((object)viewItem).GetType() == typeof(TViewItem);
	}

	public sealed override bool CanRender(ViewItem viewItem)
	{
		if (viewItem is TViewItem viewItem2)
		{
			return CanRender(viewItem2);
		}
		return false;
	}

	protected override System.Type GetTypeComponent(ViewItem viewItem)
	{
		return typeof(TComponent);
	}

	protected override System.Type GetInputsTypeComponent(System.Type typeComponent)
	{
		return typeof(TInputs);
	}
}
public abstract class ViewItemRenderer<TViewItem, TComponent, TInputs, TContext> : ViewItemRenderer<TViewItem, TComponent, TInputs, TContext, IController> where TViewItem : ViewItem where TComponent : BaseViewItemComponent<TViewItem, TInputs, TContext, IController> where TInputs : IInputs where TContext : IContext
{
	protected ViewItemRenderer(ILifetimeScope currentScope)
		: base(currentScope)
	{
	}
}
public abstract class ViewItemRenderer<TViewItem, TComponent> : ViewItemRenderer<TViewItem, TComponent, Inputs, Context, IController> where TViewItem : ViewItem where TComponent : BaseViewItemComponent<TViewItem, Inputs, Context, IController>
{
	protected ViewItemRenderer(ILifetimeScope currentScope)
		: base(currentScope)
	{
	}
}
[Component(Order = 2147483647)]
public class ViewItemRenderer : IViewItemRenderer
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public IViewModel owner;

		public ViewItem viewItem;

		public ViewItemRenderer _003C_003E4__this;

		internal ReactElement[] _003CRender_003Eb__0(IData data)
		{
			DataStackItem dataStackItem = new DataStackItem(data);
			owner?.SetDynamicData(dataStackItem);
			ReactElement[] result = ((viewItem is RootViewItem) ? _003C_003E4__this.RenderChilds(viewItem, owner).ToArrayReactElement() : null);
			IViewModel viewModel = owner;
			if (viewModel != null)
			{
				viewModel.RestoreDynamicData(dataStackItem);
				return result;
			}
			return result;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public ViewItemRenderer _003C_003E4__this;

		public IViewModel owner;

		internal IRenderContent _003CRenderChilds_003Eb__0(ViewItem item)
		{
			return _003C_003E4__this.ViewItemComponentCreatorService.Create(item, owner, (IInputs)null);
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public System.Type typeVi;

		internal bool _003CGetTypeComponent_003Eb__0(System.Type el)
		{
			System.Type type = el.get_BaseType().GetGenericArguments()[0];
			if (type != null)
			{
				return type == typeVi;
			}
			return false;
		}
	}

	private readonly ILifetimeScope currentScope;

	private System.Collections.Generic.IEnumerable<IWrapComponent> wrapComponents;

	private IComponentManager componentManager;

	private IViewItemComponentCreatorService viewItemComponentCreatorService;

	private IReactComponentCreatorService reactComponentCreatorService;

	private System.Collections.Generic.IEnumerable<IWrapComponent> WrapComponents => wrapComponents ?? (wrapComponents = ((IScopeContext)currentScope).Resolve<System.Collections.Generic.IEnumerable<IWrapComponent>>());

	private IComponentManager ComponentManager => componentManager ?? (componentManager = ((IScopeContext)currentScope).Resolve<IComponentManager>());

	protected IViewItemComponentCreatorService ViewItemComponentCreatorService => viewItemComponentCreatorService ?? (viewItemComponentCreatorService = ((IScopeContext)currentScope).Resolve<IViewItemComponentCreatorService>());

	protected IReactComponentCreatorService ReactComponentCreatorService => reactComponentCreatorService ?? (reactComponentCreatorService = ((IScopeContext)currentScope).Resolve<IReactComponentCreatorService>());

	public ViewItemRenderer(ILifetimeScope currentScope)
	{
		this.currentScope = currentScope;
	}

	public virtual bool CanRender(ViewItem viewItem)
	{
		return true;
	}

	public virtual IRenderContent Render(ViewItem viewItem, IViewModel owner, IInputs inputs = null)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.owner = owner;
		CS_0024_003C_003E8__locals0.viewItem = viewItem;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		System.Type typeComponent = GetTypeComponent(CS_0024_003C_003E8__locals0.viewItem);
		if (typeComponent == null)
		{
			return null;
		}
		if (inputs == null)
		{
			inputs = CreateInputs(CS_0024_003C_003E8__locals0.viewItem);
		}
		IInputs inputs2 = inputs;
		if (inputs2 != null)
		{
			if (!(inputs2 is Inputs inputs3))
			{
				if (!(inputs2 is InputsChildrenFunc inputsChildrenFunc))
				{
					if (inputs2 is InputsChildren inputsChildren)
					{
						inputsChildren.Children = Union<ReactElement[], Func<IData, ReactElement[]>>.op_Implicit((CS_0024_003C_003E8__locals0.viewItem is RootViewItem) ? RenderChilds(CS_0024_003C_003E8__locals0.viewItem, CS_0024_003C_003E8__locals0.owner).ToArrayReactElement() : null);
					}
				}
				else
				{
					inputsChildrenFunc.Children = delegate(IData data)
					{
						DataStackItem dataStackItem = new DataStackItem(data);
						CS_0024_003C_003E8__locals0.owner?.SetDynamicData(dataStackItem);
						ReactElement[] result = ((CS_0024_003C_003E8__locals0.viewItem is RootViewItem) ? CS_0024_003C_003E8__locals0._003C_003E4__this.RenderChilds(CS_0024_003C_003E8__locals0.viewItem, CS_0024_003C_003E8__locals0.owner).ToArrayReactElement() : null);
						IViewModel owner2 = CS_0024_003C_003E8__locals0.owner;
						if (owner2 != null)
						{
							owner2.RestoreDynamicData(dataStackItem);
							return result;
						}
						return result;
					};
				}
			}
			else
			{
				inputs3.Children = ((CS_0024_003C_003E8__locals0.viewItem is RootViewItem) ? RenderChilds(CS_0024_003C_003E8__locals0.viewItem, CS_0024_003C_003E8__locals0.owner).ToArrayReactElement() : null);
			}
		}
		IReactViewItemInputModel inputModel = BaseInitViewModel(typeComponent, CS_0024_003C_003E8__locals0.viewItem, CS_0024_003C_003E8__locals0.owner, inputs);
		return CreateComponent(typeComponent, inputModel);
	}

	protected virtual IRenderContent[] RenderChilds(ViewItem viewItem, IViewModel owner)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.owner = owner;
		if (viewItem is RootViewItem rootViewItem)
		{
			return Enumerable.Select<ViewItem, IRenderContent>((System.Collections.Generic.IEnumerable<ViewItem>)rootViewItem.Items, (Func<ViewItem, IRenderContent>)((ViewItem item) => CS_0024_003C_003E8__locals0._003C_003E4__this.ViewItemComponentCreatorService.Create(item, CS_0024_003C_003E8__locals0.owner, (IInputs)null))).ToArray();
		}
		return (IRenderContent[])(object)new IRenderContent[0];
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

	public IReactViewItemInputModel BaseInitViewModel(System.Type typeComponent, ViewItem viewItem, IViewModel owner = null, IInputs inputs = null)
	{
		IReactViewItemInputModel reactViewItemInputModel = CreateInputModel(typeComponent, viewItem);
		reactViewItemInputModel.Key = GetElementKey(viewItem);
		reactViewItemInputModel.Inputs = inputs;
		reactViewItemInputModel.Owner = owner;
		reactViewItemInputModel.ViewItem = viewItem;
		reactViewItemInputModel.RootScope = currentScope;
		reactViewItemInputModel.DataStack = owner?.GetDynamicData()?.Clone();
		return reactViewItemInputModel;
	}

	protected virtual IReactViewItemInputModel CreateInputModel(System.Type typeComponent, ViewItem viewItem)
	{
		System.Type inputsTypeComponent = GetInputsTypeComponent(typeComponent);
		return (IReactViewItemInputModel)Activator.CreateInstance(typeof(ViewItemInputModel<, >).MakeGenericType(new System.Type[2]
		{
			((object)viewItem).GetType(),
			inputsTypeComponent
		}));
	}

	protected virtual System.Type GetInputsTypeComponent(System.Type typeComponent)
	{
		System.Type[] genericArguments = typeComponent.get_BaseType().GetGenericArguments();
		if (genericArguments.Length > 2)
		{
			return genericArguments[1];
		}
		return typeof(Inputs);
	}

	protected virtual System.Type GetTypeComponent(ViewItem viewItem)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
		CS_0024_003C_003E8__locals0.typeVi = ((object)viewItem).GetType();
		return Enumerable.FirstOrDefault<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)ComponentManager.GetTypes(typeof(IReactComponent)), (Func<System.Type, bool>)delegate(System.Type el)
		{
			System.Type type = el.get_BaseType().GetGenericArguments()[0];
			return type != null && type == CS_0024_003C_003E8__locals0.typeVi;
		});
	}

	protected virtual string GetElementKey(ViewItem viewItem)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Guid uid = viewItem.Uid;
		return ((object)(Guid)(ref uid)).ToString();
	}

	private IInputs CreateInputs(ViewItem viewItem)
	{
		System.Type typeComponent = GetTypeComponent(viewItem);
		return (IInputs)Activator.CreateInstance(GetInputsTypeComponent(typeComponent));
	}
}

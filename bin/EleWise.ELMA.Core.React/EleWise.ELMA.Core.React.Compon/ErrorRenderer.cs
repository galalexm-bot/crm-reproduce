using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.React.ExtensionPoints;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Core.UI.Model;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Components;

[Component(Order = 10)]
internal sealed class ErrorRenderer : BaseReactRenderer
{
	private readonly ILifetimeScope currentScope;

	private IComponentManager componentManager;

	private IComponentManager ComponentManager => componentManager ?? (componentManager = ((IScopeContext)currentScope).Resolve<IComponentManager>());

	public ErrorRenderer(ILifetimeScope currentScope)
		: base(currentScope)
	{
		this.currentScope = currentScope;
	}

	public override bool CanRender(System.Type typeComponent)
	{
		return typeComponent == typeof(IErrorComponent);
	}

	public override IRenderContent Render(System.Type typeComponent, IViewModel owner, IInputs inputs = null)
	{
		System.Type typeComponent2 = Enumerable.FirstOrDefault<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)ComponentManager.GetTypes(typeof(IErrorComponent)));
		IReactInputModel inputModel = BaseInitViewModel(typeComponent2, owner, inputs);
		return CreateComponent(typeComponent2, inputModel);
	}

	public override IReactInputModel BaseInitViewModel(System.Type typeComponent, IViewModel owner, IInputs inputs = null)
	{
		IReactInputModel reactInputModel = CreateInputModel(typeComponent);
		reactInputModel.Key = inputs?.Key ?? typeComponent.get_Name();
		IErrorInputs errorInputs = (IErrorInputs)Activator.CreateInstance(BaseReactRenderer.GetInputsType(typeComponent));
		if (inputs is IErrorInputs errorInputs2)
		{
			errorInputs.Key = errorInputs2.Key;
			errorInputs.Message = errorInputs2.Message;
			errorInputs.StackShow = errorInputs2.StackShow;
			((Inputs)errorInputs).Children = ((Inputs)errorInputs2).Children;
		}
		reactInputModel.Inputs = errorInputs;
		reactInputModel.Owner = owner;
		reactInputModel.RootScope = currentScope;
		reactInputModel.DataStack = owner?.GetDynamicData()?.Clone();
		return reactInputModel;
	}
}

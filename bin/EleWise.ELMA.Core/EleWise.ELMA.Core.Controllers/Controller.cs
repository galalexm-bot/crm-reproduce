using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.Controllers;

[Component(CreateInstancePerResolve = true)]
public abstract class Controller<TContext> : IController where TContext : IContext
{
	private readonly IComponentContainer _003CComponent_003Ek__BackingField;

	private readonly TContext _003CContext_003Ek__BackingField;

	public IComponentContainer Component => _003CComponent_003Ek__BackingField;

	public TContext Context => _003CContext_003Ek__BackingField;

	IContext IController.Context => Context;
}

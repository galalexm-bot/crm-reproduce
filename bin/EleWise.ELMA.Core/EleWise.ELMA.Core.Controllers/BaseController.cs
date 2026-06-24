using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.Controllers;

public abstract class BaseController<TContext, TServerController> : Controller<TContext>, IClientController, IController where TContext : IContext where TServerController : IServerController
{
	private readonly TServerController _003CServer_003Ek__BackingField;

	public TServerController Server => _003CServer_003Ek__BackingField;

	IServerController IClientController.Server => Server;
}
[Component(CreateInstancePerResolve = true)]
public abstract class BaseController<TServerController> : IClientController, IController where TServerController : IServerController
{
	private readonly IContext _003CContext_003Ek__BackingField;

	private readonly IComponentContainer _003CComponent_003Ek__BackingField;

	private readonly TServerController _003CServer_003Ek__BackingField;

	public IContext Context => _003CContext_003Ek__BackingField;

	public IComponentContainer Component => _003CComponent_003Ek__BackingField;

	IServerController IClientController.Server => Server;

	public TServerController Server => _003CServer_003Ek__BackingField;
}

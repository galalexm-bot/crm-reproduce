using System;
using System.Threading.Tasks;
using Bridge.React;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public abstract class BaseCustomView<TContext, TController> : ICustomView where TContext : IContext
{
	private IComponentViewItemViewModel viewModel;

	private readonly Action<Action<TController>> _003CDispatch_003Ek__BackingField;

	private readonly Func<Func<TController, System.Threading.Tasks.Task>, System.Threading.Tasks.Task> _003CDispatchAsync_003Ek__BackingField;

	private readonly TContext _003CContext_003Ek__BackingField;

	private readonly TController _003CController_003Ek__BackingField;

	protected Action<Action<TController>> Dispatch => _003CDispatch_003Ek__BackingField;

	protected Func<Func<TController, System.Threading.Tasks.Task>, System.Threading.Tasks.Task> DispatchAsync => _003CDispatchAsync_003Ek__BackingField;

	protected TContext Context => _003CContext_003Ek__BackingField;

	protected TController Controller => _003CController_003Ek__BackingField;

	protected BaseCustomView(IComponentViewItemViewModel viewModel)
	{
	}

	protected ReactElement GetSlotContent(Guid uid = default(Guid))
	{
		return null;
	}

	public abstract ReactElement Render();
}
public abstract class BaseCustomView<TController> : ICustomView
{
	private IComponentViewItemViewModel viewModel;

	private readonly IContext _003CContext_003Ek__BackingField;

	private readonly TController _003CController_003Ek__BackingField;

	protected IContext Context => _003CContext_003Ek__BackingField;

	protected TController Controller => _003CController_003Ek__BackingField;

	protected BaseCustomView(IComponentViewItemViewModel viewModel)
	{
	}

	public void Dispatch(Action<TController> arg)
	{
	}

	public System.Threading.Tasks.Task DispatchAsync(Func<TController, System.Threading.Tasks.Task> arg)
	{
		return null;
	}

	protected ReactElement GetSlotContent(Guid uid = default(Guid))
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return ((IRootComponent)viewModel).GetSlotContent(uid);
	}

	public abstract ReactElement Render();
}

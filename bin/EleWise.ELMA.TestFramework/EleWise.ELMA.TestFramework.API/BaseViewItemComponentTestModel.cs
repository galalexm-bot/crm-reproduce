using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.TestFramework.API;

public class BaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController> : IBaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController> where TViewItem : IViewItem where TInputs : IInputs where TContext : IContext where TController : IController
{
	private TViewItem _003CViewItem_003Ek__BackingField;

	private TContext _003CContext_003Ek__BackingField;

	private TController _003CController_003Ek__BackingField;

	private TInputs _003CInputs_003Ek__BackingField;

	public TViewItem ViewItem
	{
		get
		{
			return _003CViewItem_003Ek__BackingField;
		}
		private set
		{
			_003CViewItem_003Ek__BackingField = value;
		}
	}

	public TContext Context
	{
		get
		{
			return _003CContext_003Ek__BackingField;
		}
		private set
		{
			_003CContext_003Ek__BackingField = value;
		}
	}

	public TController Controller
	{
		get
		{
			return _003CController_003Ek__BackingField;
		}
		private set
		{
			_003CController_003Ek__BackingField = value;
		}
	}

	public TInputs Inputs
	{
		get
		{
			return _003CInputs_003Ek__BackingField;
		}
		private set
		{
			_003CInputs_003Ek__BackingField = value;
		}
	}

	public BaseViewItemComponentTestModel(IViewItem viewItem, IInputs inputs, IContext context, IController controller)
	{
		ViewItem = (TViewItem)viewItem;
		Inputs = (TInputs)inputs;
		Context = (TContext)context;
		Controller = (TController)controller;
	}
}

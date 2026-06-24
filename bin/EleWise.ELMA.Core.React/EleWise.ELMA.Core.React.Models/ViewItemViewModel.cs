using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.React.Services;
using EleWise.ELMA.Core.UI.Services;
using EleWise.ELMA.Dispatcher;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Models;

public class ViewItemViewModel : ViewItemViewModel<IViewItem>
{
	public ViewItemViewModel(IViewModelCreatorService viewModelCreatorService, ILazy<IViewItemComponentCreatorService> viewItemComponentCreatorService, IReactComponentCreatorService reactComponentCreatorService, IDispatcher dispatcher, IApplicationData applicationData)
		: base(viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher, applicationData)
	{
	}
}
public class ViewItemViewModel<TViewItem> : ViewItemViewModel<TViewItem, IContext, IController> where TViewItem : IViewItem
{
	public ViewItemViewModel(IViewModelCreatorService viewModelCreatorService, ILazy<IViewItemComponentCreatorService> viewItemComponentCreatorService, IReactComponentCreatorService reactComponentCreatorService, IDispatcher dispatcher, IApplicationData applicationData)
		: base(viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher, applicationData)
	{
	}
}
public class ViewItemViewModel<TViewItem, TContext, TController> : ViewModel<TContext, TController>, IHideEmptyViewItemViewModel, IReactViewItemViewModel, IViewItemViewModel, IViewModel, IReactViewModel, IReactService where TViewItem : IViewItem where TContext : IContext where TController : IController
{
	private IComponentContainer componentSettings;

	private readonly IDispatcher dispatcher;

	private readonly IApplicationData applicationData;

	private IHideEmptyModel hideEmptyModel;

	protected IReactViewItemInputModel ViewItemInputModel => (IReactViewItemInputModel)base.InputModel;

	public override bool Ready => true;

	public TViewItem ViewItem
	{
		get
		{
			if (ViewItemInputModel == null)
			{
				return default(TViewItem);
			}
			return (TViewItem)ViewItemInputModel.ViewItem;
		}
	}

	public override IComponentContainer Component
	{
		get
		{
			if (componentSettings == null)
			{
				componentSettings = new ViewItemComponentContainer(this);
			}
			return componentSettings;
		}
	}

	public virtual bool IsDesignModeDeep => IsViewItemDesignModeDeep(ViewItem);

	IViewItem IViewItemViewModel.ViewItem => ViewItem;

	public IHideEmptyModel HideEmptyModel => hideEmptyModel;

	public ViewItemViewModel(IViewModelCreatorService viewModelCreatorService, ILazy<IViewItemComponentCreatorService> viewItemComponentCreatorService, IReactComponentCreatorService reactComponentCreatorService, IDispatcher dispatcher, IApplicationData applicationData)
		: base(viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher)
	{
		this.dispatcher = dispatcher;
		this.applicationData = applicationData;
	}

	public bool TestIdEnabled()
	{
		if (applicationData is IDevelopApplicationData developApplicationData)
		{
			return developApplicationData.TestMode == TestMode.AutoTest;
		}
		return false;
	}

	protected override void GenerateController(System.Type typeController)
	{
		if (typeController == null || typeController.get_IsInterface())
		{
			return;
		}
		controller = base.ViewModelCreatorService.ControllerCreator(typeController, base.Context, this, ViewItem);
		CreateDispatcher(typeController);
		if (!IsDesignModeDeep)
		{
			dispatcher.Dispatch(new ActionCommand("ControllerCommand", "", controller, (Func<System.Threading.Tasks.Task>)delegate
			{
				CreateValidation();
				CreateHideableModel();
				return System.Threading.Tasks.Task.get_CompletedTask();
			}));
		}
	}

	public override System.Threading.Tasks.Task Destroy()
	{
		if (HideEmptyModel != null)
		{
			HideEmptyModel.Destroy();
		}
		return base.Destroy();
	}

	protected void CreateHideableModel()
	{
		if (!(base.RenderOwner is IHideEmptyViewItemContainer hideEmptyViewItemContainer) || !((object)ViewItem is IHideEmptyViewItem hideEmptyViewItem))
		{
			return;
		}
		IHideEmptyContainerModel owner = hideEmptyViewItemContainer.HideEmptyViewItemContainer.FindOwner(ViewItem);
		if (hideEmptyViewItemContainer.HideEmptyViewItemContainer.IsHideEmpty(ViewItem))
		{
			if (hideEmptyViewItem.IsHideable && controller is IHideable hideable)
			{
				hideEmptyModel = new ViewItemHideEmptyModel(base.RenderOwner, hideable, owner);
			}
			else if (!hideEmptyViewItem.IsHideable)
			{
				hideEmptyModel = new HideEmptyContainerModel(hideEmptyViewItemContainer.HideEmptyViewItemContainer, ViewItem, owner);
			}
		}
		else if (hideEmptyViewItem.HideEmpty == HideEmptyEnum.ShowEmpty)
		{
			hideEmptyModel = new ShowEmptyModel(owner);
		}
		if (hideEmptyModel != null)
		{
			hideEmptyModel.Init();
		}
	}

	private bool IsViewItemDesignModeDeep(IViewItem viewItemCheck)
	{
		if (viewItemCheck is ComponentViewItem componentViewItem && componentViewItem.ViewMode == InterfaceBuilderViewMode.Design)
		{
			return true;
		}
		if (base.RenderOwner is IMetadataViewModel metadataViewModel)
		{
			if (!metadataViewModel.IsDesignMode)
			{
				return metadataViewModel.IsDesignModeDeep;
			}
			return true;
		}
		return false;
	}

	private System.Threading.Tasks.Task _003CGenerateController_003Eb__20_0()
	{
		CreateValidation();
		CreateHideableModel();
		return System.Threading.Tasks.Task.get_CompletedTask();
	}
}

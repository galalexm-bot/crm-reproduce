using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Dispatcher;
using EleWise.ELMA.Model.Validation;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public class ComponentContainer : IComponentContainer
{
	protected readonly IViewModel ViewModel;

	public virtual bool ReadOnly
	{
		get
		{
			if (RenderOwner != null)
			{
				return RenderOwner.Component.ReadOnly;
			}
			return false;
		}
	}

	public virtual IValidationModel Validation
	{
		get
		{
			if (!(ViewModel is IValidationViewModel validationViewModel))
			{
				return null;
			}
			return validationViewModel.ValidationModel;
		}
	}

	public virtual string Name => ViewModel.InputModel.Key;

	public virtual IComponentDispatcher Dispatcher => ViewModel.ComponentDispatcher;

	protected IViewModel RenderOwner => ViewModel.RenderOwner;

	public ComponentContainer(IViewModel viewModel)
	{
		Contract.ArgumentNotNull(viewModel, "viewModel");
		ViewModel = viewModel;
	}
}

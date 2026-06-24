using System;
using System.Threading.Tasks;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public class InputComponentContainer : ComponentContainer, IInputComponentContainer
{
	public Func<IKeyboardEvent, System.Threading.Tasks.Task> OnKeyPress => ((BaseInputViewModel)ViewModel).OnKeyPress;

	public Func<IFocusEvent, System.Threading.Tasks.Task> OnFocus => ((BaseInputViewModel)ViewModel).OnFocus;

	public Func<IChangeEvent, System.Threading.Tasks.Task> OnBlur => ((BaseInputViewModel)ViewModel).OnBlur;

	public InputComponentContainer(IViewModel viewModel)
		: base(viewModel)
	{
	}
}

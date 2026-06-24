using System;
using System.Threading.Tasks;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public interface IInputComponentContainer
{
	Func<IKeyboardEvent, System.Threading.Tasks.Task> OnKeyPress { get; }

	Func<IFocusEvent, System.Threading.Tasks.Task> OnFocus { get; }

	Func<IChangeEvent, System.Threading.Tasks.Task> OnBlur { get; }
}

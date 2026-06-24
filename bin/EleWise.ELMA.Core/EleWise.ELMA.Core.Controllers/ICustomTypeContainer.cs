using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.Controllers;

public interface ICustomTypeContainer : IComponentContainer
{
	TypeSettings Settings { get; }

	IClientAttributes Attributes { get; }

	IClientPropertyMetadata PropertyMetadata { get; }

	System.Threading.Tasks.Task OnKeyPress(IKeyboardEvent ev);

	System.Threading.Tasks.Task OnBlur(IChangeEvent ev);

	System.Threading.Tasks.Task OnFocus(IFocusEvent ev);
}
public interface ICustomTypeContainer<TValue, TSettings> : ICustomTypeContainer, IComponentContainer
{
	new TSettings Settings { get; }

	System.Threading.Tasks.Task OnKeyPress(IKeyboardEvent<TValue> ev);

	System.Threading.Tasks.Task OnBlur(IChangeEvent<TValue> ev);

	System.Threading.Tasks.Task OnFocus(IFocusEvent<TValue> ev);
}

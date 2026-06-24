using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.ViewModel;

public interface IBaseInputs : IInputs
{
	object Model { get; set; }

	Func<object> GetFunc { get; set; }

	Action<object> SetFunc { get; set; }

	Func<ViewAttributes> Attributes { get; set; }

	Func<IPropertyMetadata> PropertyMetadata { get; set; }

	Func<IViewModel> PropertyOwner { get; set; }

	Func<string> DataTestId { get; set; }

	Func<bool, FocusableType> FocusableType { get; set; }

	Func<IKeyboardEvent, System.Threading.Tasks.Task> OnKeyPress { get; set; }

	Func<IChangeEvent, System.Threading.Tasks.Task> OnBlur { get; set; }

	Func<IFocusEvent, System.Threading.Tasks.Task> OnFocus { get; set; }
}

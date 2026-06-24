using EleWise.ELMA.Dispatcher;
using EleWise.ELMA.Model.Validation;

namespace EleWise.ELMA.Model.ViewModel;

public interface IComponentContainer
{
	bool ReadOnly { get; }

	IValidationModel Validation { get; }

	string Name { get; }

	IComponentDispatcher Dispatcher { get; }
}

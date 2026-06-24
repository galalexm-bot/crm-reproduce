using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public interface IReactInputModel : IInputModel, IDataExtension
{
	ILifetimeScope RootScope { get; set; }
}
public interface IReactInputModel<TInputs> : IInputModel<TInputs>, IInputModel, IReactInputModel, IDataExtension where TInputs : IInputs
{
}

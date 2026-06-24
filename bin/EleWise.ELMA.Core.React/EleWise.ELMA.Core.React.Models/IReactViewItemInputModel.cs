using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public interface IReactViewItemInputModel : IViewItemInputModel, IInputModel, IReactInputModel, IDataExtension
{
}
public interface IReactViewItemInputModel<TViewItem> : IReactViewItemInputModel<TViewItem, Inputs>, IViewItemInputModel<TViewItem, Inputs>, IInputModel<Inputs>, IInputModel, IViewItemInputModel, IReactInputModel<Inputs>, IReactInputModel, IDataExtension, IReactViewItemInputModel
{
}
public interface IReactViewItemInputModel<TViewItem, TInputs> : IViewItemInputModel<TViewItem, TInputs>, IInputModel<TInputs>, IInputModel, IViewItemInputModel, IReactInputModel<TInputs>, IReactInputModel, IDataExtension, IReactViewItemInputModel where TInputs : IInputs
{
}

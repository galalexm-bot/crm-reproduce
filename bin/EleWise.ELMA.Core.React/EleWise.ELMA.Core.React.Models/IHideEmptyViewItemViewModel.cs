using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public interface IHideEmptyViewItemViewModel : IReactViewItemViewModel, IViewItemViewModel, IViewModel, IReactViewModel, IReactService
{
	IHideEmptyModel HideEmptyModel { get; }
}

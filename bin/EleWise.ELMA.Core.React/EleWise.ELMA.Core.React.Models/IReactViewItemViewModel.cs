using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public interface IReactViewItemViewModel : IViewItemViewModel, IViewModel, IReactViewModel, IReactService
{
	bool TestIdEnabled();
}

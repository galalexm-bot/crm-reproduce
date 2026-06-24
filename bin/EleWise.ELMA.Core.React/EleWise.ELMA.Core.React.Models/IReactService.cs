using EleWise.ELMA.Core.React.Services;
using EleWise.ELMA.Core.UI.Services;

namespace EleWise.ELMA.Core.React.Models;

public interface IReactService
{
	IViewItemComponentCreatorService ViewItemComponentCreatorService { get; }

	IReactComponentCreatorService ReactComponentCreatorService { get; set; }

	IViewModelCreatorService ViewModelCreatorService { get; set; }
}

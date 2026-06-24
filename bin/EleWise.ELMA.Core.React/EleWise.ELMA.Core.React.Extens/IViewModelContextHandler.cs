using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.ExtensionPoints;

[ExtensionPoint]
public interface IViewModelContextHandler
{
	bool Check(IViewModel viewModel);

	IContext CreateContext(IContextCreationParameters parameters, IViewItem viewItem);
}

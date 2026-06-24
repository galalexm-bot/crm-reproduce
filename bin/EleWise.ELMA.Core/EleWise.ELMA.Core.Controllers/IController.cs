using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.Controllers;

[ExtensionPoint]
public interface IController
{
	IContext Context { get; }

	IComponentContainer Component { get; }
}

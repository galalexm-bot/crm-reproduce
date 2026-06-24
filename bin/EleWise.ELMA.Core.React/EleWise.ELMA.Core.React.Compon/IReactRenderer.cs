using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.UI.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Components;

[ExtensionPoint]
public interface IReactRenderer
{
	IRenderContent Render(System.Type typeComponent, IViewModel owner, IInputs inputs = null);

	bool CanRender(System.Type typeComponent);
}

using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.UI.Model;

namespace EleWise.ELMA.Core.React.ExtensionPoints;

[ExtensionPoint]
public interface IWrapComponent
{
	IRenderContent Wrap(IRenderContent renderContent);
}

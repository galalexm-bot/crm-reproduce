using Bridge.React;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.UI.Model;

namespace EleWise.ELMA.Core.React.ExtensionPoints;

[ExtensionPoint(false)]
public interface IReactComponent : IRenderContent
{
	ReactElement ReactElement { get; }
}

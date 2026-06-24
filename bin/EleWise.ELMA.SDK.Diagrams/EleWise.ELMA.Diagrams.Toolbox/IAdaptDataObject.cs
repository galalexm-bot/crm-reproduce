using System.Windows.Forms;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Diagrams.Toolbox;

[ExtensionPoint(ComponentType.All)]
public interface IAdaptDataObject
{
	object AdaptShapeDescriptor(IDataObject dataObject, string format);
}

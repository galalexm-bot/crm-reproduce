using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IPropertyCustomView
{
	bool HasCustomView(IPropertyMetadata property, bool readOnly);
}

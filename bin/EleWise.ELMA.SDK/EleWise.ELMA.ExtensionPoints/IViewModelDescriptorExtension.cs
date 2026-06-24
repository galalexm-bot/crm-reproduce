using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IViewModelDescriptorExtension
{
	bool Check(string typeRef);

	IMetadata GetMetadata(string typeRef);
}

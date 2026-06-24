using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Helpers;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IConvertTypeMapper
{
	bool RelativeConvertNeeded(IPropertyMetadata originalPropertyMetadata, IPropertyMetadata convertPropertyMetadata);

	object Convert(object obj);
}

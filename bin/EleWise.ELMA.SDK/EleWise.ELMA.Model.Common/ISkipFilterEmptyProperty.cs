using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Common;

[ExtensionPoint(ComponentType.All)]
public interface ISkipFilterEmptyProperty
{
	bool TryProperty(PropertyMetadata metadata, ClassMetadata filterMetadata);
}

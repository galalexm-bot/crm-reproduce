using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IClearBeforeDelEntityMetadata
{
	void Clear(object oldobjectMd);
}

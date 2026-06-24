using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
public interface IIgnoreUidUI
{
	bool NeedIgnoreUid(EntityMetadata md);
}

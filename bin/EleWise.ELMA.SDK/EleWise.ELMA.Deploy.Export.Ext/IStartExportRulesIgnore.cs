using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IStartExportRulesIgnore
{
	bool IgnoreThisEntity(EntityMetadata entityMetadata);
}

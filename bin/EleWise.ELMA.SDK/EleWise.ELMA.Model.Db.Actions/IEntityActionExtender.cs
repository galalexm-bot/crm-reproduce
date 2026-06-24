using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Db.Actions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IEntityActionExtender
{
	void Extend(IDbModelUpdater updater, EntityMetadata metadata);
}

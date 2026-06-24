using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

public interface IDbTypeInfo
{
	bool AutoIncrementSupported { get; }

	TypeDbStructures GetDbStructures(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata);

	bool ApplyDbChanges(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata);
}

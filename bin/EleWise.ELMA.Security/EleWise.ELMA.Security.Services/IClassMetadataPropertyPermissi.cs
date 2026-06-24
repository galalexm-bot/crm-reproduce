using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Services;

[ExtensionPoint(ComponentType.Server)]
public interface IClassMetadataPropertyPermissionAdapter : IPropertyPermissionAdapter
{
	IMetadata GetBaseMetadata(IAbstractPropertyProfile profile);

	IMetadata GetBaseMetadata(IPropertyOwnerProfile owner);
}

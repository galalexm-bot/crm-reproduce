using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IMapTypeExtension
{
	bool Can(IMetadata metadata);

	string TableName(IMetadata metadata);
}

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IExecuteMetadataPropertyExtension
{
	void MetadataPropertyProcessing(IPropertyMetadata importedProperty, IPropertyMetadata baseProperty, ClassMetadata importedMetadata, ReadMetadataParameters parameters);
}

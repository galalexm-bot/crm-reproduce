using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
internal interface IPublicationHandler
{
	void UpdateMetadata(IMetadata metadata);

	void UpdateMetadataItem(IMetadataItem source, IMetadataItem destination);
}

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public interface IReadMetadataResult
{
	IMetadata Metadata { get; }

	bool TestMetadata();

	void SaveMetadata();
}

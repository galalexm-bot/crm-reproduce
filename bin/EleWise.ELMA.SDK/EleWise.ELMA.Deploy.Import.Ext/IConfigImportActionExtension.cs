using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
public interface IConfigImportActionExtension
{
	void OnPreStartTest(PreStartTestImportParameters parameters);

	IReadMetadataResult OnReadMetadata(ReadMetadataParameters parameters, bool isTestRead);

	void OnPrePublish(PrePublishParameters parameters);

	void OnPostPublish(PostPublishParameters parameters);
}

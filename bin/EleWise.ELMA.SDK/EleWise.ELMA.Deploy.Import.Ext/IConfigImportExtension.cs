using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
public interface IConfigImportExtension
{
	void OnPostCompleteTest(PostCompleteTestImportParameters parameters);

	void OnPreStartImport(PreStartImportParameters parameters);

	void OnPreReadPackets(PreReadPacketsParameters parameters);

	void OnPostReadPackets(PostReadPacketsParameters parameters);

	void OnPostCompleteImport(PostCompleteImportParameters parameters);

	void OnImportSuccessfull(ImportSuccessfullParameters parameters);
}

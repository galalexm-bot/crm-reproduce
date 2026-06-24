using System.Collections.Generic;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Deploy.Services;

public interface ITagService
{
	List<string> TagLanguage { get; }

	List<string> TagDataBase { get; }

	List<string> TagEdition { get; }

	bool ValidateTags(ElmaStoreComponentManifest manifest);

	bool ValidateTags(ElmaStoreComponentManifest manifest, out List<TestImportMessages> messages);
}

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Documents.Deploy.Export;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Deploy.Import;

[Component]
public class DocumentMetadataImport : MetadataImport
{
	public override void CreateFakeChapter(NamedMetadata namedMd, BPMAppFakeManifest fakeManifest, BPMAppManifest manifest)
	{
		if (fakeManifest != null && namedMd != null && namedMd.GetType() == typeof(DocumentMetadata))
		{
			fakeManifest.GetOrCreateChapterByUid(DocumentsExportConsts.ExportExtensionUid).GetOrCreateItemByUid(namedMd.Uid, namedMd.DisplayName);
		}
	}
}

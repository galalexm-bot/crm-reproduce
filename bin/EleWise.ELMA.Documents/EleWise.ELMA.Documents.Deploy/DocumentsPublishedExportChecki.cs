using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Components;
using EleWise.ELMA.Deploy.Export.Models;
using EleWise.ELMA.Model.Metadata.Managers;

namespace EleWise.ELMA.Documents.Deploy.Export.Components;

[Component]
internal sealed class DocumentsPublishedExportCheckingRule : ObjectsPublishedExportCheckingRule
{
	public DocumentsPublishedExportCheckingRule(MetadataItemHeaderManager metadataItemHeaderManager)
		: base(metadataItemHeaderManager)
	{
	}

	public override IExportCheckingResult Check(IExportCheckingContext context)
	{
		Contract.ArgumentNotNull(context, "context");
		BaseExportCheckingResult result = new BaseExportCheckingResult();
		if (context.Settings.CustomSettings.TryGetValue(DocumentsExportConsts.ExportExtensionUid, out var value) && value is DocumentExportSetting documentExportSetting && documentExportSetting.DocTypes != null)
		{
			Check(documentExportSetting.DocTypes, result);
		}
		return result;
	}

	protected override string PublishedMissed(string displayName)
	{
		return SR.T("Документ \"{0}\" неопубликован", displayName);
	}
}

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Documents.Metadata;

namespace EleWise.ELMA.Documents.Deploy.Import;

[Component(Order = 100)]
public class DocumentExecuteMetadataExtension : EntityExecuteMetadataExtension<DocumentMetadata>
{
	protected override void MergeMetadata(DocumentMetadata mdDocImported, DocumentMetadata mdDocBase, bool isTestRead, ReadMetadataParameters parameters)
	{
		base.MergeMetadata(mdDocImported, mdDocBase, isTestRead, parameters);
		if (!isTestRead && mdDocBase != null && mdDocImported != null)
		{
			mdDocBase.TemplateName = mdDocImported.TemplateName;
			mdDocBase.IsAllowRename = mdDocImported.IsAllowRename;
			mdDocBase.UploadButton = mdDocImported.UploadButton;
			mdDocBase.ScanButton = mdDocImported.ScanButton;
			mdDocBase.TemplateButton = mdDocImported.TemplateButton;
			if (!mdDocBase.ControlOnSending)
			{
				mdDocBase.ControlOnSending = mdDocImported.ControlOnSending;
			}
			mdDocBase.MultipleRegistration = mdDocImported.MultipleRegistration;
			mdDocBase.DisableCreate = mdDocImported.DisableCreate;
			mdDocBase.UseLifeCycle = mdDocImported.UseLifeCycle;
		}
	}
}

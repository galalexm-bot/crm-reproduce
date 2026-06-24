using System;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Documents.Types;

public class DocumentFolderTypeDescriptor : EntitySubTypeDescriptor<IFolder>
{
	private static readonly Guid FolderEntityUid = new Guid("b04c011a-27a4-4fab-8bc6-a1a2ab61a1c3");

	public override Type SettingsType => typeof(DocumentFolderSettings);

	protected override Guid EntityUid => FolderEntityUid;

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		DocumentFolderSettings documentFolderSettings = base.CreateSettingsForFilterProperty(propertyMetadata) as DocumentFolderSettings;
		if (documentFolderSettings != null)
		{
			documentFolderSettings.SelectOnlyEdit = false;
			documentFolderSettings.SelectOnlyCreate = false;
		}
		return documentFolderSettings;
	}
}

using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class CreateDocumentSettingsBlock : DocumentStorageSettingsBlockBase<CreateDocumentSettings>
{
	public static Guid UID = new Guid("CC73A5C0-358A-4077-A1DE-2ED1CD4D6000");

	public override Guid BlockUid => UID;

	public override string BlockName => SR.T("Настройки создания документа");
}

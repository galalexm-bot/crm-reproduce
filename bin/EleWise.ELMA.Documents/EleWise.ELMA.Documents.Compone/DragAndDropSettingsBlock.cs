using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class DragAndDropSettingsBlock : DocumentStorageSettingsBlockBase<DragAndDropSettings>
{
	public static Guid UID = new Guid("992AD967-CF60-43A2-AEE8-EFE525EBE455");

	public override Guid BlockUid => UID;

	public override string BlockName => SR.T("Создание документов через Drag-n-drop");
}

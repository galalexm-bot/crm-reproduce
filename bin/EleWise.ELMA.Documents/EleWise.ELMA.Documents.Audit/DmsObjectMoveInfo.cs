using System;

namespace EleWise.ELMA.Documents.Audit;

[Serializable]
public class DmsObjectMoveInfo
{
	public long OldFolderId { get; set; }

	public long NewFolderId { get; set; }
}

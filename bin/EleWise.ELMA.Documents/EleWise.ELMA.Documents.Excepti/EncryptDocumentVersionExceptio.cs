using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Documents.Exceptions;

[Serializable]
public class EncryptDocumentVersionException : SystemException
{
	public long VersionId { get; set; }

	public Guid ActionUid { get; set; }

	public EncryptDocumentVersionException()
	{
	}

	public EncryptDocumentVersionException(long versionId, Guid actionUid)
	{
		VersionId = versionId;
		if (actionUid != Guid.Empty)
		{
			ActionUid = actionUid;
		}
	}

	public EncryptDocumentVersionException(long versionId)
		: this(versionId, Guid.Empty)
	{
		VersionId = versionId;
	}

	protected EncryptDocumentVersionException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

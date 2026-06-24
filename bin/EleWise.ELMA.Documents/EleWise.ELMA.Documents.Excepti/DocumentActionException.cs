using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Exceptions;

[Serializable]
public class DocumentActionException : SystemException
{
	public long DocumentId { get; set; }

	public Guid ActionUid { get; set; }

	public IDocument GetDocument()
	{
		if (DocumentId == 0L)
		{
			return null;
		}
		return DocumentManager.Instance.Load(DocumentId);
	}

	public DocumentActionInfo GetAction()
	{
		return DocumentActionsProfileManager.Instance.GetActionInfo(ActionUid);
	}

	public DocumentActionException()
	{
	}

	public DocumentActionException(long documentId, Guid actionUid)
	{
		DocumentId = documentId;
		ActionUid = actionUid;
	}

	public DocumentActionException(long documentId, Guid actionUid, string message)
		: base(message)
	{
		DocumentId = documentId;
		ActionUid = actionUid;
	}

	protected DocumentActionException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

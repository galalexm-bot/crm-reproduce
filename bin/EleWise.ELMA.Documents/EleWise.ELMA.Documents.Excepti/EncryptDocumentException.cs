using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Documents.Exceptions;

[Serializable]
public class EncryptDocumentException : SystemException
{
	public long DocumentId { get; set; }

	public EncryptDocumentException()
	{
	}

	public EncryptDocumentException(long documentId)
	{
		DocumentId = documentId;
	}

	protected EncryptDocumentException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

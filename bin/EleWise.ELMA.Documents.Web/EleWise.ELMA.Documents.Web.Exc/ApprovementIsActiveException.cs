using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Exceptions;

[Serializable]
public class ApprovementIsActiveException : SystemException
{
	private long[] documents { get; set; }

	public IEnumerable<IDocument> Documents => from d in documents
		where d > 0
		select DocumentManager.Instance.Load(d);

	public ApprovementIsActiveException(IEnumerable<long> documents)
	{
		this.documents = documents.ToArray();
	}

	protected ApprovementIsActiveException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public ApprovementIsActiveException(long document)
	{
		documents = new long[1] { document };
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Documents.Models;

[Serializable]
public class CreateDocumentHistory
{
	public const int MaxItemsCount = 5;

	[OptionalField]
	private DocumentVersionStatus _documentVersionStatus;

	public List<Guid> TypeList { get; set; }

	public DocumentVersionStatus DocumentVersionStatus
	{
		get
		{
			return _documentVersionStatus;
		}
		set
		{
			_documentVersionStatus = value;
		}
	}

	public void Add(Guid typeUid)
	{
		if (!TypeList.Contains(typeUid))
		{
			TypeList.Insert(0, typeUid);
			if (TypeList.Count > 5)
			{
				TypeList.RemoveAt(5);
			}
		}
	}

	public CreateDocumentHistory()
	{
		TypeList = new List<Guid>();
		DocumentVersionStatus = DocumentVersionStatus.Current;
	}
}

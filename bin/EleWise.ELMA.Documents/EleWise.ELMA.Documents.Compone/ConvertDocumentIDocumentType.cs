using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Types;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class ConvertDocumentIDocumentType : IConvertDocumentTypeUids
{
	public Guid GetTypesDescriptor()
	{
		return DocumentTypeDescriptor.UID;
	}

	public object GetUid(object obj)
	{
		return (long)((IEntity)obj).GetId();
	}
}

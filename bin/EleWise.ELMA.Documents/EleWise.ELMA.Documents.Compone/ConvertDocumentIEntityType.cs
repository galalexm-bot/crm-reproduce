using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class ConvertDocumentIEntityType : IConvertDocumentTypeUids
{
	public Guid GetTypesDescriptor()
	{
		return EntityDescriptor.UID;
	}

	public object GetUid(object obj)
	{
		return (long)((IEntity)obj).GetId();
	}
}

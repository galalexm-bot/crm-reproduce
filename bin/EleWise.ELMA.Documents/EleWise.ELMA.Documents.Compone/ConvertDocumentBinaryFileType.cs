using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class ConvertDocumentBinaryFileType : IConvertDocumentTypeUids
{
	public Guid GetTypesDescriptor()
	{
		return BinaryFileDescriptor.UID;
	}

	public object GetUid(object obj)
	{
		return ((BinaryFile)obj).Id;
	}
}

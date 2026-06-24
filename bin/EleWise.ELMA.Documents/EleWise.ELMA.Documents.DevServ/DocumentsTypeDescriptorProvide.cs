using System;
using System.Collections.Generic;
using EleWise.ELMA.DevServer.TypeDescriptors;
using EleWise.ELMA.Documents.Descriptors;
using EleWise.ELMA.Documents.Types;

namespace EleWise.ELMA.Documents.DevServer;

internal sealed class DocumentsTypeDescriptorProvider : ITypeDescriptorProvider
{
	public IEnumerable<Type> GetTypeDescriptors()
	{
		return new Type[4]
		{
			typeof(DocumentAttachmentDescriptor),
			typeof(DocumentFolderTypeDescriptor),
			typeof(DocumentTemplatesListTypeDescriptor),
			typeof(DocumentTypeDescriptor)
		};
	}
}

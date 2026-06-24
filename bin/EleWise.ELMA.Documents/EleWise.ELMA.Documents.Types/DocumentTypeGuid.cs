using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Documents.Types;

[Component]
public class DocumentTypeGuid : IInheriteEntityMetadataGuid
{
	public Guid Uid => DocumentTypeDescriptor.UID;
}

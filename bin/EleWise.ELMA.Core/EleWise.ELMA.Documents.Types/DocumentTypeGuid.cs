using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Documents.Types;

[Component]
internal sealed class DocumentTypeGuid : IInheriteEntityMetadataGuid
{
	public Guid Uid => DocumentTypeDescriptor.UID;
}
